using Carpark.BL.Services.Interfaces;
using Carpark.Data.Entities;
using Carpark.ViewModel.Common;
using Microsoft.AspNetCore.Mvc;

namespace Carpark.Web.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserBiz _userBiz;

        public UserController(IUserBiz userBiz)
        {
            _userBiz = userBiz;
        }

        [HttpPost("carparkNo")]
        public async Task<ApiResult<UserFavorite>> MarkFavoriteCarpark(string carparkNo)
        {
            return await _userBiz.MarkFavoriteCarpark(carparkNo);
        }
    }
}
