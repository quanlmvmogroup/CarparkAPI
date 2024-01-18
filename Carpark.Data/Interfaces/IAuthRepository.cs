using Carpark.Core.Models;
using Carpark.Data.Entities;

namespace Carpark.Core.Interfaces
{
    public interface IAuthRepository : IBaseRepository<User>
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
