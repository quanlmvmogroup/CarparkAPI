using Microsoft.AspNetCore.Http;
using System.Data;

namespace Carpark.BL.Services.Interfaces
{
    public interface IImportFileBiz
    {
        DataTable GenerateDataTable(string fileName, Stream fileStream, int index = 0);
    }
}
