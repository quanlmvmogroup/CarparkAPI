using Carpark.Core.Common;
using Carpark.Core.Entities;
using Carpark.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Carpark.Web.Controllers
{
    public class UserFavoriteController : BaseController
    {
        private readonly IUserFavoriteService _userFavoriteService;

        public UserFavoriteController(IUserFavoriteService userFavoriteService)
        {
            _userFavoriteService = userFavoriteService;
        }

        [HttpPost("carparkNo")]
        public async Task<ApiResult<UserFavorite>> MarkFavoriteCarpark(string carparkNo)
        {
            return await _userFavoriteService.MarkFavoriteCarpark(carparkNo);
        }
    }
}
