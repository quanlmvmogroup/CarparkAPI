namespace Carpark.Core.Entities
{
    public class ShortTermParkingType
    {
        public short? Id { get; set; }

        public string ShortTermParkingName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public virtual ICollection<CarPark> CarParkNavigation { get; set; }

    }
}
