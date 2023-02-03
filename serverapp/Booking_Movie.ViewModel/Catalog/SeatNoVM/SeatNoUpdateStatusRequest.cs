using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.SeatNoVM
{
    public class SeatNoUpdateStatusRequest
    {
        public int SeatNoId { get; set; }
        public bool Status { get; set; }
    }
}
