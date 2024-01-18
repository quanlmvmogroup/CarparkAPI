using Carpark.Core.Common;
using Carpark.Core.Entities;
using Carpark.Core.Interfaces;
using Carpark.Infrastructure.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Carpark.Infrastructure.Respositories
{
    public class UserFavoriteRepository : BaseRepository<UserFavorite>, IUserFavoriteRepository
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public UserFavoriteRepository(CarparkDbContext dbContext, IHttpContextAccessor contextAccessor) : base(dbContext)
        {
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

            var userFavorite = await DbSet
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
                DbSet.Add(userFavorite);
            }

            await SaveChangeAsync();

            return new ApiSuccessResult<UserFavorite>(userFavorite);
        }
    }
}
