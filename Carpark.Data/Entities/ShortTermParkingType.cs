namespace Carpark.Data.Entities
{
    public class ShortTermParkingType
    {
        public short Id { get; set; }
        public string ShortTermParkingName { get; set; }
        public virtual ICollection<CarPark> CarParkNavigation { get; set; }

    }
}
