namespace Carpark.Core.Entities
{
    public class CarPark
    {
        public string CarParkNo { get; set; }
        public string Address { get; set; }
        public decimal XCoord { get; set; }
        public decimal YCoord { get; set; }
        public short CarParkType { get; set; }
        public short ShortTermParkingType { get; set; }
        public short CarParkDeck { get; set; }
        public short CarParkBasement { get; set; }
        public decimal GantryHeight { get; set; }
        public short FreeParkingType { get; set; }
        public short NightParkingType { get; set; }
        public short ParkingTypeSystem { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt{ get; set; }
        public virtual UserFavorite UserFavoriteNavigation { get; set; }
        public virtual CarParkType CarParkTypeNavigation { get; set; }
        public virtual ParkingTypeSystem TypeOfParkingSystemNavigation { get; set; }
        public virtual ShortTermParkingType ShortTermParkingNavigation { get; set; }
        public virtual FreeParkingType FreeParkingNavigation { get; set; }
        public virtual NightParkingType NightParkingNavigation { get; set; }
    }
}
