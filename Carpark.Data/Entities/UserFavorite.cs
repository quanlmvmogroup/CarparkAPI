using Carpark.Data.Entities;
using System.Text.Json.Serialization;

namespace Carpark.Core.Entities
{
    public class UserFavorite
    {
        public Guid UserId { get; set; }
        public string CarParkNo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        [JsonIgnore]
        public virtual CarPark CarParkNavigation { get; set; }
        public virtual User UserNavigation { get; set; }
    }
}
