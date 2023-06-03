using Booking_Movie.Application.System.Users;
using Booking_Movie.ViewModel.System.Users;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Booking_Movie.Utilities.Constants;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("signin")]
        [AllowAnonymous]
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
        public async Task<IActionResult> SignIn([FromBody] LoginRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var resultToken = await _userService.Authenticate(request);

            if (resultToken.StatusResponse != 1) return BadRequest(resultToken);
            HttpContext.Session.SetString(SystemConstant.AppSettings.Token, resultToken.Token!);

            return Ok(resultToken);
        }

        [HttpPost("signup")]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp([FromBody] RegisterRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userService.Register(request);

            if (!result) return BadRequest("Register fail!");
            
            return Ok("Sign up successful");
        }
        
        [HttpPost("admin/signup")]
        [AllowAnonymous]
        public async Task<IActionResult> SignUpAdmin([FromForm] RegisterRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userService.RegisterAdmin(request);

            if (!result) return BadRequest("Register fail!");
            
            return Ok("Sign up successful");
        }

        [HttpPost("logout")]
       public async Task<IActionResult> Logout()
        {
            var response = new Dictionary<string, object>();
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            response.Add("isLogout", true);
            return Ok(response);
        }


    }
}
