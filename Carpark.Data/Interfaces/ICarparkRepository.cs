using Carpark.Core.Common;
using Carpark.Core.Entities;
using Carpark.Core.Models;

namespace Carpark.Core.Interfaces
{
    public interface ICarparkRepository : IBaseRepository<CarPark>
    {
        Task<PaginatedResponseModel<CarPark>> GetListCarpark(SearchingCarparkInfoRequest request);
    }
}
