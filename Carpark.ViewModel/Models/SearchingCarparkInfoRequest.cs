using Carpark.Data.Common;
using Carpark.Utilities.Enums;

namespace Carpark.ViewModel.Models
{
    public class SearchingCarparkInfoRequest : PagingRequestBase
    {
        public ECarParkType? CarParkType { get; set; }
        public ETypeOfParking? ParkingTypeSystem { get; set; }
        public EShortTermParking? ShortTermParkingType { get; set; }
        public EFreeParking? FreeParkingType { get; set; }
        public ENightParkingType? NightParkingType { get; set; }
        public decimal? GantryHeight { get; set; }

    }
}
