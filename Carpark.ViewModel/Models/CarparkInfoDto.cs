using Carpark.Utilities.Enums;

namespace Carpark.Data.Models
{
    public class CarparkInfoDto
    {
        public string CarParkNo { get; set; }
        public string? Address { get; set; }
        public decimal? XCoord { get; set; }
        public decimal? YCoord { get; set; }
        public short? CarParkDeck { get; set; }
        public decimal? GantryHeight { get; set; }
        public short? CarParkBasement { get; set; }
        public ECarParkType? CarParkType { get; set; }
        public ETypeOfParking? ParkingTypeSystem { get; set; }
        public EShortTermParking? ShortTermParkingType { get; set; }
        public EFreeParking? FreeParkingType { get; set; }
        public ENightParkingType? NightParkingType { get; set; }
    }
}
