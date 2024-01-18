namespace Carpark.Core.Entities
{
    public class FreeParkingType
    {
        public short? Id { get; set; }

        public string FreeParkingTypeName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public virtual ICollection<CarPark> CarParkNavigation { get; set; }

    }
}
