namespace Carpark.Data.Entities
{
    public class CarParkType
    {
        public short Id { get; set; }
        public string CarParkTypeName { get; set; }
        public virtual ICollection<CarPark> CarParkNavigation { get; set; }
    }
}
