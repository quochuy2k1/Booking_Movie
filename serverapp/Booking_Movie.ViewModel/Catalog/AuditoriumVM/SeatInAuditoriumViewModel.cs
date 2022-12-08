using Booking_Movie.ViewModel.Catalog.SeatVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.AuditoriumVM
{
    public class SeatInAuditoriumViewModel
    {
        public string PhysicalName { get; set; } = null!;
        public List<SeatViewModel> Seats { get; set; } = null!;
    }
}
