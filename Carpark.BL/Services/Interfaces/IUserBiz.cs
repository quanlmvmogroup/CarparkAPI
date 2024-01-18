using Carpark.Data.Entities;
using Carpark.ViewModel.Common;

namespace Carpark.BL.Services.Interfaces
{
    public interface IUserBiz
    {
        Task<ApiResult<UserFavorite>> MarkFavoriteCarpark(string carparkNo);
    }
}
