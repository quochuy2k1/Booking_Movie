using Booking_Movie.ViewModel.Catalog.BookingVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Bookings
{
    public interface IBookingService
    {
        Task<List<BookingViewModel>?> GetAllBooking();
    }
}
