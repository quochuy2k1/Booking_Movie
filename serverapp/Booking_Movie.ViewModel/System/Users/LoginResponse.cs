using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.System.Users
{
    public class LoginResponse
    {
        public string? Token { get; set; }
        public DateTime? Exp { get; set; }
        public string? SessionId { get; set; }
        public int? StatusResponse { get; set; }
        public string? StatusMessageResponse { get; set; }
        public LoginUserViewModel? AppUser { get; set; }
        public LoginErrorResponse? Error {get; set;}
    }
}
