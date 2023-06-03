using Booking_Movie.Data.Entities;
using Booking_Movie.Utilities.Constants;
using Booking_Movie.ViewModel.System.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Booking_Movie.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<LoginResponse> Authenticate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);

            if (user == null)
            {
                return new LoginResponse()
                {
                    StatusMessageResponse = StatusMessageResponseContant.USER_NAME_NOT_EXISTS,
                    StatusResponse = StatusResponseContant.FAILED,
                    Error = new LoginErrorResponse()
                    {
                        UserNameError = "Tài khoản không đúng"
                    }
                };
            }

            var expJWT = DateTime.Now.AddHours(3);
            var Jti = Guid.NewGuid().ToString();
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe!.Value, true);
            if (result.Succeeded)
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>()
                {
                    new Claim("userIdClaim",  user.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, user.UserName),
                    new Claim(ClaimTypes.Name, $"{user.LastName} {user.FirstName}"),
                    new Claim(JwtRegisteredClaimNames.Jti, Jti),
                };

                foreach (var role in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, role));
                }

                JwtSecurityToken token = GetToken(authClaims, expJWT);
                return new LoginResponse()
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Exp = expJWT,
                    SessionId = Jti,
                    StatusMessageResponse = StatusMessageResponseContant.SIGN_IN_SUCCESS,
                    StatusResponse = StatusResponseContant.SUCCESS,
                    AppUser = new LoginUserViewModel()
                    {
                        UserName = user.UserName,
                        LastName = user.LastName,
                        FirstName = user.FirstName,
                        Roles = userRoles.ToList()
                    }
                };


            }
            return new LoginResponse()
            {
                StatusMessageResponse = StatusMessageResponseContant.PASSWORD_INCORRECT,
                StatusResponse = StatusResponseContant.FAILED,
                Error = new LoginErrorResponse()
                {
                   
                    PasswordError = "Mật khẩu không đúng"
                }
            };
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var userExist = await _userManager.FindByNameAsync(request.UserName);
            if (userExist == null)
            {
                AppUser user = new AppUser()
                {
                    UserName = request.UserName,
                    Email = request.Email,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = request.PhoneNumber,
                };

                var result = await _userManager.CreateAsync(user, request.ConfirmPassword);
                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync(UserRoleConstants.USER))
                        await _roleManager.CreateAsync(new AppRole(UserRoleConstants.USER) { Description = "Tài khoản người dùng thông thường" });

                    if (await _roleManager.RoleExistsAsync(UserRoleConstants.USER))
                    {
                        await _userManager.AddToRoleAsync(user, UserRoleConstants.USER);
                    }

                    return true;
                }
            }
            return false;
        }
        public async Task<bool> RegisterAdmin(RegisterRequest request)
        {
            var userExist = await _userManager.FindByNameAsync(request.UserName);
            if (userExist == null)
            {
                AppUser user = new AppUser()
                {
                    UserName = request.UserName,
                    Email = request.Email,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = request.PhoneNumber,
                };

                var result = await _userManager.CreateAsync(user, request.ConfirmPassword);
                if (!result.Succeeded) return false;

                //Tạo mới role

                if (!await _roleManager.RoleExistsAsync(UserRoleConstants.ADMIN))
                    await _roleManager.CreateAsync(new AppRole(UserRoleConstants.ADMIN) { Description = "Tài khoản quản trị hệ thống" });
                if (!await _roleManager.RoleExistsAsync(UserRoleConstants.USER))
                    await _roleManager.CreateAsync(new AppRole(UserRoleConstants.USER) { Description = "Tài khoản người dùng thông thường" });


                if (await _roleManager.RoleExistsAsync(UserRoleConstants.ADMIN))
                {
                    await _userManager.AddToRoleAsync(user, UserRoleConstants.ADMIN);
                }
                if (await _roleManager.RoleExistsAsync(UserRoleConstants.USER))
                {
                    await _userManager.AddToRoleAsync(user, UserRoleConstants.USER);
                }

                return true;
            }
            return false;
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims, DateTime exp)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires: exp,
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}