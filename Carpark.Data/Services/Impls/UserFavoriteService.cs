using Carpark.Core.Common;
using Carpark.Core.Entities;
using Carpark.Core.Interfaces;
using Carpark.Core.Services.Interfaces;

namespace Carpark.Core.Services.Impls
{
    public class UserFavoriteService : IUserFavoriteService
    {
        private readonly IUserFavoriteRepository _userFavoriteRepository;
        public UserFavoriteService(IUserFavoriteRepository userFavoriteRepository)
        {
            _userFavoriteRepository = userFavoriteRepository;
        }

        public async Task<ApiResult<UserFavorite>> MarkFavoriteCarpark(string carparkNo)
        {
            return await _userFavoriteRepository.MarkFavoriteCarpark(carparkNo);
        }
    }
}
