using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.BookingVM;
using System.Linq;

namespace Booking_Movie.Data.Repositories
{
    public interface IBookingRepository: IRepository<Booking>
    {
        IQueryable<BookingViewModel> GetAllBooking();
    }
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        public BookingRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }



        public IQueryable<BookingViewModel> GetAllBooking()
        {
            var booking = from b in this.MovieContext.Bookings
                          join scr in this.MovieContext.Screenings on b.ScreeningId equals scr.Id
                          join au in this.MovieContext.Users on b.AppUserId equals au.Id
                          join p in this.MovieContext.PaymentMethods on b.PaymentMethodId equals p.Id
                          join cp in this.MovieContext.Coupons on b.CouponId equals cp.Id
                          select new BookingViewModel()
                          {
                              Id = b.Id,
                              Total = b.Total,
                              CreatedDate = b.CreatedDate,
                              CouponId = b.CouponId,
                              PaymentMethod = p.Name,
                              ShowTime = scr.ShowTime,
                              flagScanner = b.Stauts!.Value,
                              UserFullName = au.FirstName + " " + au.LastName,
                              Combos =(from bcb in this.MovieContext.BookingCombos
                                                                 join cb in this.MovieContext.Combos on bcb.ComboId equals cb.Id
                                                                 where b.Id == bcb.BookingId
                                                                 select cb.Name).ToArray(),
                              Tickets =(from bt in this.MovieContext.BookingTickets
                                                                 join t in this.MovieContext.Tickets on bt.TicketId equals t.Id
                                                                 where b.Id == bt.BookingId
                                                                 select t.Name).ToArray(),
                              SeatRevered = (from bs in this.MovieContext.SeatReserveds
                                                              join sn in this.MovieContext.SeatNos on bs.SeatNoId equals sn.Id
                                                              join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                                                              where b.Id == bs.BookingId
                                                              select s.Row + s.Number ).ToArray()
                          };

            return booking.AsQueryable();
        }
    
    }
}