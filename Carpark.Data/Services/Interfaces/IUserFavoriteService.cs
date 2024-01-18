using Carpark.Core.Common;
using Carpark.Core.Entities;

namespace Carpark.Core.Services.Interfaces
{
    public interface IUserFavoriteService
    {
        Task<ApiResult<UserFavorite>> MarkFavoriteCarpark(string carparkNo);
    }
}
