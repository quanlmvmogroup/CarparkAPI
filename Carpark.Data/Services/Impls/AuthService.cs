using Carpark.BL.Services.Interfaces;
using Carpark.Core.Interfaces;
using Carpark.Core.Models;

namespace Carpark.Core.Services.Impls
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            return await _authRepository.Authenticate(request);
        }
    }
}
