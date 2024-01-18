namespace Carpark.Data.Entities
{
    public class FreeParkingType
    {
        public short Id { get; set; }
        public string FreeParkingTypeName { get; set; }
        public virtual ICollection<CarPark> CarParkNavigation { get; set; }

    }
}
