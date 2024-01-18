using Carpark.Core.Common;
using Carpark.Core.Models;
using Carpark.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Carpark.Web.Controllers
{
    public class CarParkController : BaseController
    {
        private readonly ICarparkService _carparkBiz;

        public CarParkController(ICarparkService biz)
        {
            _carparkBiz = biz;
        }

        [HttpGet]
        [Route("list")]
        public async Task<PaginatedResponseModel<CarparkInfoDto>> GetListCarparkInfo([FromQuery]SearchingCarparkInfoRequest request)
        {
            return await _carparkBiz.GetListCarparkInfo(request);
        }
    }
}
