namespace Carpark.Data.Entities
{
    public class ParkingTypeSystem
    {
        public short Id { get; set; }
        public string ParkingTypeSystemName { get; set; }
        public virtual ICollection<CarPark> CarParkNavigation { get; set; }


    }
}
