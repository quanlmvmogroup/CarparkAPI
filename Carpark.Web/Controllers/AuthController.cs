using Carpark.BL.Services.Interfaces;
using Carpark.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Carpark.Web.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IAuthBiz _auth;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IConfiguration _configuration;

        public AuthController(IAuthBiz auth, IHttpContextAccessor contextAccessor, IConfiguration configuration)
        {
            _auth = auth;
            _contextAccessor = contextAccessor;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            string accessToken = await _auth.Authenticate(request);

            if (string.IsNullOrEmpty(accessToken))
            {
                return Unauthorized("Invalid credentials");
            }

            string userId = GetUserIdFromToken(accessToken);

            _contextAccessor.HttpContext?.Session.SetString("UserId", userId);
            _contextAccessor.HttpContext?.Session.SetString("AccessToken", accessToken);

            return Ok(new { AccessToken = accessToken, UserId = userId });
        }

        private string GetUserIdFromToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);

            try
            {
                var claimsPrincipal = tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = _configuration["Jwt:Issuer"],
                    ValidAudience = _configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateLifetime = true
                }, out _);

                var userIdClaim = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier);
                return userIdClaim?.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Token decoding error: {ex.Message}");
                return null;
            }
        }
    }
}
