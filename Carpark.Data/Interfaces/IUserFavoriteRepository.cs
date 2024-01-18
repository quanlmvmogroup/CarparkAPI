using Carpark.Core.Common;
using Carpark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpark.Core.Interfaces
{
    public interface IUserFavoriteRepository : IBaseRepository<UserFavorite>
    {
        Task<ApiResult<UserFavorite>> MarkFavoriteCarpark(string carparkNo);
    }
}
