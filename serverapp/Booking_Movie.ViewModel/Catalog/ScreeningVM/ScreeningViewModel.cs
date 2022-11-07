using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.ScreeningVM
{
    public class ScreeningViewModel
    {
        public string CinameName { get; set; } = null!;
        public string? ScreeningTypeName { get; set; }
        public DateTime[]? ShowTime { get; set; } 
    }
}
