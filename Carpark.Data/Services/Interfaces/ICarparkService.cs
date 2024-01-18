using Carpark.Core.Common;
using Carpark.Core.Models;

namespace Carpark.Core.Services.Interfaces
{
    public interface ICarparkService
    {
        Task<PaginatedResponseModel<CarparkInfoDto>> GetListCarparkInfo(SearchingCarparkInfoRequest request);
    }
}
