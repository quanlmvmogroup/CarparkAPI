using Carpark.BL.Services.Interfaces;
using Carpark.Data.CarparkDbContext;
using Carpark.Data.Entities;
using Carpark.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Carpark.BL.Services.Impls
{
    public class UserBiz : IUserBiz
    {
        private readonly CarparkDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        public UserBiz(CarparkDbContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public async Task<ApiResult<UserFavorite>> MarkFavoriteCarpark(string carparkNo)
        {
            var userIdClaim = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userIdClaim) || !Guid.TryParse(userIdClaim, out Guid uID))
            {
                return new ApiErrorResult<UserFavorite>
                {
                    IsSuccessed = false,
                    Message = "Invalid UserId",
                };
            }

            var checkExistedCarpark = await _context.Carparks.FindAsync(carparkNo);
            if (checkExistedCarpark == null)
                return new ApiErrorResult<UserFavorite>($"Không tìm thấy Carpark với mã {carparkNo}");

            var userFavorite = await _context.UserFavorites
                .FirstOrDefaultAsync(uf => uf.UserId == uID);

            if (userFavorite != null)
            {
                userFavorite.CarParkNo = carparkNo;
            }
            else
            {
                userFavorite = new UserFavorite
                {
                    UserId = uID,
                    CarParkNo = carparkNo
                };
                _context.UserFavorites.Add(userFavorite);
            }

            await _context.SaveChangesAsync();
            return new ApiSuccessResult<UserFavorite>(userFavorite);
        }
    }
}
