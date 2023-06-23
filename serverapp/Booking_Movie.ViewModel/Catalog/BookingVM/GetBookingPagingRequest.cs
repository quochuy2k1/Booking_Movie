using Booking_Movie.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.BookingVM
{
    public class GetBookingPagingRequest : DXPagingRequestBase
    {
        public int? MovieId { get; set; }
        public int? CinemaId { get; set; }
    }
}
