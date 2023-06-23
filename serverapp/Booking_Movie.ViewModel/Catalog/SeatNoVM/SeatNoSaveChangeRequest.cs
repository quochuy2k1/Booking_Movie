using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.SeatNoVM
{
    public class SeatNoSaveChangeRequest
    {
        public List<SeatNoAction>? SeatNoActions { get;set; }  
    }

    public class SeatNoAction
    {
        public string? Action { get; set; }
        public List<SeatNoClientViewModel>? SeatNos { get; set; }
    }
}
