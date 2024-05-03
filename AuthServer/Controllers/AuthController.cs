using AuthServer.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Validate credentials
            if (!await _userService.ValidateCredentialsAsync(username, password))
            {
                return Unauthorized("Invalid username or password");
            }

            // Generate JWT token
            var token = await _authService.GenerateJwtTokenAsync(username);

            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            if (await _userService.RegisterUser(username, password))
                return Ok();

            return BadRequest();
        }

    }
}
