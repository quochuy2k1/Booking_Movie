using Booking_Movie.ViewModel.Catalog.BookingVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Report.Booking
{
    public interface IBookingReport
    {
        Task<BookingHistoryViewModel?> GetBookingDetailByQrCode(string qrContent, string host);

    }
}
