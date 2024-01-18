using Carpark.Core.Services.Interfaces;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;
using System.Globalization;

namespace Carpark.Core.Services.Impls
{
    public class ImportFileService : IImportFileService
    {
        public DataTable GenerateDataTable(string fileName, Stream fileStream, int index = 0)
        {
            var ext = Path.GetExtension(fileName);

            var data = new DataTable();

            if (ext == ".xlsx" || ext == ".xls")
                data = ReadExcelFile(fileStream, index);
            else if (ext == ".csv")
                data = ReadCsvFile(fileStream);
            else if (ext == ".json")
                data = ReadJsonFile(fileStream);

            return data;
        }

        private DataTable ReadExcelFile(Stream fileStream, int index)
        {
            DataTable dtTable = new DataTable();
            List<string> rowList = new List<string>();

            fileStream.Position = 0;
            XSSFWorkbook xssWorkbook = new XSSFWorkbook(fileStream);
            var sheet = xssWorkbook.GetSheetAt(index);
            IRow headerRow = sheet.GetRow(0);
            int cellCount = headerRow.LastCellNum;

            // Header
            for (int j = 0; j < cellCount; j++)
            {
                ICell cell = headerRow.GetCell(j);
                if (cell == null || string.IsNullOrWhiteSpace(cell.ToString())) continue;
                dtTable.Columns.Add(cell.ToString());
            }

            // Content
            try
            {
                for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null)
                    {
                        dtTable.Rows.Add(rowList);
                        rowList.Clear();
                        continue;
                    }

                    if (row.Cells.All(d => d.CellType == CellType.Blank)) continue;
                    for (int j = 0; j < dtTable.Columns.Count; j++) // Adjusted to use dtTable.Columns.Count
                    {
                        if (row.GetCell(j) is null || string.IsNullOrWhiteSpace(row.GetCell(j)?.ToString()))
                        {
                            rowList.Add(string.Empty);
                        }
                        else if (row.GetCell(j) != null)
                        {
                            rowList.Add(row.GetCell(j).ToString());
                        }
                    }

                    if (rowList.Count > 0)
                        dtTable.Rows.Add(rowList.ToArray());
                    rowList.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return TrimEndDataTable(dtTable);
        }

        private DataTable ReadCsvFile(Stream fileStream)
        {
            DataTable dtTable = new DataTable();
            List<string> rowList = new List<string>();

            using (var reader = new StreamReader(fileStream))
            {
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    // Read the header row to create columns
                    csv.Read();
                    csv.ReadHeader();
                    var headerRecord = csv.HeaderRecord;

                    foreach (string header in headerRecord)
                    {
                        dtTable.Columns.Add(header);
                    }

                    // Read each row and add to the DataTable
                    while (csv.Read())
                    {
                        rowList.Clear();
                        for (int i = 0; i < headerRecord.Length; i++)
                        {
                            rowList.Add(csv.GetField(i) ?? string.Empty);
                        }

                        dtTable.Rows.Add(rowList.ToArray());
                    }
                }
            }

            return TrimEndDataTable(dtTable);
        }

        private DataTable ReadJsonFile(Stream fileStream)
        {
            DataTable dtTable = new DataTable();
            List<string> rowList = new List<string>();

            using (var streamReader = new StreamReader(fileStream))
            {
                using (JsonTextReader reader = new JsonTextReader(streamReader))
                {
                    bool isHeaderRead = false;

                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.StartArray)
                        {
                            // Assume that the first array encountered in the JSON is the header
                            if (!isHeaderRead)
                            {
                                isHeaderRead = true;

                                var headers = JArray.Load(reader);
                                foreach (var header in headers)
                                {
                                    dtTable.Columns.Add(header.ToString());
                                }
                            }
                            else
                            {
                                // Content
                                while (reader.Read() && reader.TokenType != JsonToken.EndArray)
                                {
                                    var value = reader.Value != null ? reader.Value.ToString() : string.Empty;
                                    rowList.Add(value);
                                }

                                if (rowList.Count > 0)
                                    dtTable.Rows.Add(rowList.ToArray());

                                rowList.Clear();
                            }
                        }
                    }
                }
            }

            return TrimEndDataTable(dtTable);
        }

        private DataTable TrimEndDataTable(DataTable dt)
        {
            int lastRowIndex = dt.Rows.Count - 1;
            while (lastRowIndex >= 0 && dt.Rows[lastRowIndex].ItemArray.All(f => f is DBNull || string.IsNullOrEmpty(f as string ?? f.ToString())))
            {
                dt.Rows.RemoveAt(lastRowIndex);
                lastRowIndex--;
            }

            return dt;
        }
    }
}
