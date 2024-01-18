using Carpark.Utilities.Enums;

namespace Carpark.Core.Models
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
        public short? CarParkType { get; set; }
        public short? ParkingTypeSystem { get; set; }
        public short? ShortTermParkingType { get; set; }
        public short? FreeParkingType { get; set; }
        public short? NightParkingType { get; set; }
    }
}
