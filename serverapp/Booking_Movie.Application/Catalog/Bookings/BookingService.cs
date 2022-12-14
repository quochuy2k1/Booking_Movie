using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.BookingVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Bookings
{
    public class BookingService: IBookingService
    {
        private readonly BookingRepository _bookingRepository;
        private readonly IUnitOfWork unitOfWork;

        public BookingService(BookingRepository actorRepository, IUnitOfWork unitOfWork)
        {
            this._bookingRepository = actorRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<BookingViewModel>?> GetAllBooking()
        {
            var bookings = await _bookingRepository.GetAllBooking().ToListAsync();
            if (bookings == null) throw new BookingMovieException("Lấy danh sách đặt vé lỗi");

            return bookings;
        }
    }
}
