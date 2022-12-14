using Booking_Movie.Application.System.Users;
using Booking_Movie.ViewModel.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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


        [HttpPost("/user/signin")]
        [AllowAnonymous]
        public async Task<IActionResult> SignIn([FromBody] LoginRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var resultToken = await _userService.Authenticate(request);

            if(resultToken.error != null) return BadRequest(resultToken.error);
            
            return Ok(resultToken);
        }

        [HttpPost("/user/signup")]
        [AllowAnonymous]
        public async Task<IActionResult> SignUp([FromBody] RegisterRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userService.Register(request);

            if (!result) return BadRequest("Register fail!");
            
            return Ok("Sign up successful");
        }
        
        [HttpPost("/user/admin/signup")]
        [AllowAnonymous]
        public async Task<IActionResult> SignUpAdmin([FromForm] RegisterRequest request)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userService.RegisterAdmin(request);

            if (!result) return BadRequest("Register fail!");
            
            return Ok("Sign up successful");
        }


    }
}
