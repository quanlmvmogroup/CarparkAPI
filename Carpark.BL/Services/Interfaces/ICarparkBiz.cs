using Carpark.Data.Common;
using Carpark.Data.Models;
using Carpark.ViewModel.Common;
using Carpark.ViewModel.Models;
using Microsoft.AspNetCore.Http;

namespace Carpark.BL.Services.Interfaces
{
    public interface ICarparkBiz
    {
        Task<CarparkInfoDto> GetCarparkInfoByCarparkNo(string carparkNo);
        Task<PagedResult<CarparkInfoDto>> GetListCarparkInfo(SearchingCarparkInfoRequest request);
    }
}
