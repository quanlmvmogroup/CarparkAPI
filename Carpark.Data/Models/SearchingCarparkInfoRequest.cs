using Carpark.Core.Common;
using Carpark.Utilities.Enums;

namespace Carpark.Core.Models
{
    public class SearchingCarparkInfoRequest : PaginatedRequestModel
    {
        public ECarParkType? CarParkType { get; set; }
        public ETypeOfParking? ParkingTypeSystem { get; set; }
        public EShortTermParking? ShortTermParkingType { get; set; }
        public EFreeParking? FreeParkingType { get; set; }
        public ENightParkingType? NightParkingType { get; set; }
        public decimal? GantryHeight { get; set; }

    }
}
