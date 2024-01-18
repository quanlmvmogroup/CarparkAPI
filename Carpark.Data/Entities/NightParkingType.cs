namespace Carpark.Data.Entities
{
    public class NightParkingType
    {
        public short Id { get; set; }
        public string NightParkingTypeName { get; set; }
        public virtual ICollection<CarPark> CarParkNavigation { get; set; }

    }
}
