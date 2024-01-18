using System.Data;

namespace Carpark.Core.Services.Interfaces
{
    public interface IImportFileService
    {
        DataTable GenerateDataTable(string fileName, Stream fileStream, int index = 0);
    }
}
