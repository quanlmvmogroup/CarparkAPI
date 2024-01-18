using Carpark.Core.Entities;
using Carpark.Core.Interfaces;
using Carpark.Core.Services.Interfaces;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CarparkQueue
{
    public class ImportFileFunction
    {
        private readonly IImportFileService _importFileBiz;
        private readonly ICarparkRepository _carparkRepository;

        public ImportFileFunction(IImportFileService importFileBiz, ICarparkRepository carparkRepository)
        {
            _importFileBiz = importFileBiz;
            _carparkRepository = carparkRepository;
        }

        [FunctionName("ImportFileFunction")]
        public async Task Run([BlobTrigger("carpark-queue/{name}", Connection = "Carpark")] Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");

            var connectionString = Environment.GetEnvironmentVariable("AzureWebJobsStorage", EnvironmentVariableTarget.Process);

            if (string.IsNullOrEmpty(connectionString))
            {
                log.LogError("CarparkDb connection string is not set.");
                return;
            }

            var cloudStorageAccount = Microsoft.Azure.Storage.CloudStorageAccount.Parse(connectionString);

            var datetimePrefix = DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "_";
            var sourceContainer = "carpark-queue";
            var destinationContainer = "carpark-queue";
            var sourceFilename = name;
            var destinationFilename = "Backup/" + datetimePrefix + name;

            var ext = Path.GetExtension(name);

            var dataTable = _importFileBiz.GenerateDataTable(name, myBlob);

            var columnMappings = new Dictionary<string, string>
            {
                { "CarParkNo", "car_park_no" },
                { "Address", "address" },
                { "XCoord", "x_coord" },
                { "YCoord", "y_coord" },
                { "CarParkType", "car_park_type" },
                { "ParkingTypeSystem", "type_of_parking_system" },
                { "ShortTermParkingType", "short_term_parking" },
                { "FreeParkingType", "free_parking" },
                { "NightParkingType", "night_parking" },
                { "CarParkDeck", "car_park_decks" },
                { "GantryHeight", "gantry_height" },
                { "CarParkBasement", "car_park_basement" }
            };

            var entities = dataTable.AsEnumerable().Select(row => new CarPark
            {
                CarParkNo = row.Field<string>("car_park_no"),
                Address = row.Field<string>("address"),
                XCoord = decimal.TryParse(row.Field<string>("x_coord"), out var xCoordValue) ? xCoordValue : default,
                YCoord = decimal.TryParse(row.Field<string>("y_coord"), out var yCoordValue) ? yCoordValue : default,
                CarParkType = short.TryParse(row.Field<string>("car_park_type"), out var carparkType) ? carparkType : default,
                ParkingTypeSystem = short.TryParse(row.Field<string>("type_of_parking_system"), out var parkingSystem) ? parkingSystem : default,
                ShortTermParkingType = short.TryParse(row.Field<string>("short_term_parking"), out var shortTermParking) ? shortTermParking : default,
                FreeParkingType = short.TryParse(row.Field<string>("free_parking"), out var freeParking) ? freeParking : default,
                NightParkingType = short.TryParse(row.Field<string>("night_parking"), out var nightParking) ? nightParking : default,
                CarParkDeck = short.TryParse(row.Field<string>("car_park_decks"), out var carparkDeck) ? carparkDeck : default,
                GantryHeight = decimal.TryParse(row.Field<string>("gantry_height"), out var gannyHeight) ? gannyHeight : default,
                CarParkBasement = short.TryParse(row.Field<string>("car_park_basement"), out var carparkBasement) ? carparkBasement : default,
                CreatedAt = DateTime.UtcNow,
                ModifiedAt = DateTime.UtcNow

            }).ToList();

            await _carparkRepository.BulkInsert(entities);

            var copyResult = CopyBlob(cloudStorageAccount, sourceContainer, destinationContainer, name, destinationFilename);

            if (copyResult.Status == CopyStatus.Success)
            {
                DeleteBlob(cloudStorageAccount, sourceContainer, sourceFilename);
            }
        }

        private static CopyState CopyBlob(Microsoft.Azure.Storage.CloudStorageAccount cloudStorageAccount, string sourceContainerName, string destinationContainerName, string sourceFileName, string destinationFileName)
        {
            var blobStorageClient = cloudStorageAccount.CreateCloudBlobClient();

            var sourceContainer = blobStorageClient.GetContainerReference(sourceContainerName);
            var destinationContainer = blobStorageClient.GetContainerReference(destinationContainerName);

            var sourceBlob = sourceContainer.GetBlobReference(sourceFileName);

            var destinationBlob = destinationContainer.GetBlobReference(destinationFileName);

            var result = destinationBlob.StartCopy(sourceBlob.Uri);

            var copyResult = destinationBlob.CopyState;

            return copyResult;
        }

        private static void DeleteBlob(Microsoft.Azure.Storage.CloudStorageAccount cloudStorageAccount, string containerName, string blobFileName)
        {
            var blobStorageClient = cloudStorageAccount.CreateCloudBlobClient();
            var container = blobStorageClient.GetContainerReference(containerName);
            var blob = container.GetBlobReference(blobFileName);
            blob.Delete();
        }
    }
}
