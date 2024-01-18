using Carpark.BL.Services.Interfaces;
using Carpark.Data.Common;
using Carpark.Data.Models;
using Carpark.ViewModel.Common;
using Carpark.ViewModel.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carpark.Web.Controllers
{
    public class CarParkController : BaseController
    {
        private readonly ICarparkBiz _biz;

        public CarParkController(ICarparkBiz biz)
        {
            _biz = biz;
        }

        [HttpGet("{carparkNo}")]
        public async Task<CarparkInfoDto> GetCarparkInfoByCarparkNo(string carparkNo)
        {
            return await _biz.GetCarparkInfoByCarparkNo(carparkNo);
        }

        [HttpGet]
        [Route("list")]
        public async Task<PagedResult<CarparkInfoDto>> GetListCarparkInfo([FromQuery]SearchingCarparkInfoRequest request)
        {
            return await _biz.GetListCarparkInfo(request);
        }
    }
}
