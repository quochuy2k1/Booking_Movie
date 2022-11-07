using System.ComponentModel.DataAnnotations;

namespace Booking_Movie.ViewModel.System.Users
{
    public class RegisterRequest
    {
        [Display(Name = "Tên")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Họ")]
        [DataType(DataType.Text)]
        public string LastName { get; set; } = null!;

        //[Display(Name = "Ngày sinh")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //public DateTime? DoB { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = null!;

        [Display(Name = "Tài khoản")]
        public string UserName { get; set; } = null!;

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Nhập lại mật khẩu")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;
    }
}