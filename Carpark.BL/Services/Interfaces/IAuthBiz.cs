using Carpark.Data.Models;

namespace Carpark.BL.Services.Interfaces
{
    public interface IAuthBiz
    {
        Task<string> Authenticate(LoginRequest request);
    }
}
