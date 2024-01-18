using Carpark.Core.Models;

namespace Carpark.BL.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
