using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.BookingComboVM;
using Booking_Movie.ViewModel.Catalog.BookingTicketVM;
using Booking_Movie.ViewModel.Catalog.BookingVM;
using Booking_Movie.ViewModel.Catalog.SeatReservedVM;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Booking_Movie.Utilities.Common;
using Microsoft.Extensions.Configuration;
using Booking_Movie.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Booking_Movie.Data.Repositories
{
    public interface IBookingRepository: IRepository<Booking>
    {
        IQueryable<BookingViewModel> GetAllBooking();
        IQueryable<BookingHistoryViewModel> GetBookingByUserId(Guid userId);
        IQueryable<BookingHistoryViewModel> GetBookingDetailByUserId(int id, Guid userId);
        IQueryable<BookingHistoryViewModel> GetBookingDetailByQrCode(string qrContent);
        Task<Booking> SaveMomoPayment(Booking entity);
        Task AddBookingTicket(int id, CreateBookingTicketRequest[] requests);
        Task AddBookingCombo(int id, CreateBookingComboRequest[] requests);
        Task<List<int>?> AddBookingSeatReserved(int id, CreateSeatReservedRequest[] requests);
        Task<Booking> UpdatePaymentStatus(string orderId, bool status);
    }
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        private readonly IConfiguration _configuration;
        public BookingRepository(BookingMovieContext movieContext, IDbFactory dbFactory, IConfiguration configuration) : base(movieContext, dbFactory)
        {
            _configuration = configuration;
        }

        public async Task AddBookingCombo(int id, CreateBookingComboRequest[] requests)
        {
            if (requests.Length == 1)
            {
                var bookingCombo = new BookingCombo()
                {
                    BookingId = id,
                    ComboId = requests[0].ComboId,
                    Quantity = requests[0].Quantity,
                    Total = requests[0].Total,
                    Stauts = false,

                };
                await this.MovieContext.BookingCombos.AddAsync(bookingCombo);

            }
            else
            {
                foreach (var createBookingCombo in requests)
                {
                    var bookingCombo = new BookingCombo()
                    {
                        BookingId = id,
                        ComboId = createBookingCombo.ComboId,
                        Quantity = createBookingCombo.Quantity,
                        Total = createBookingCombo.Total,
                        Stauts = false,
                    };
                    await this.MovieContext.BookingCombos.AddAsync(bookingCombo);
                }
            }
        }

        public async Task<List<int>?> AddBookingSeatReserved(int id, CreateSeatReservedRequest[] requests)
        {
            List<int> lstSeatNoId = new List<int>();
            if (requests.Length == 1)
            {
                var seatReserved = new SeatReserved()
                {
                    BookingId= id,
                    SeatNoId = requests[0].SeatNoId
                };
                await this.MovieContext.SeatReserveds.AddAsync(seatReserved);
                lstSeatNoId.Add(requests[0].SeatNoId);
                return lstSeatNoId;

            }
            else
            {
                foreach (var seatNo in requests)
                {
                    var seatReserved = new SeatReserved()
                    {
                        BookingId = id,
                        SeatNoId= seatNo.SeatNoId
                    };
                    await this.MovieContext.SeatReserveds.AddAsync(seatReserved);
                    lstSeatNoId.Add(seatNo.SeatNoId);
                    
                }
                return lstSeatNoId;
            }
            return null;
        }

        public async Task AddBookingTicket(int id, CreateBookingTicketRequest[] requests)
        {
            if (requests.Length == 1)
            {
                var bookingTicket = new BookingTicket()
                {
                    BookingId = id,
                    TicketId = requests[0].TicketId,
                    Quantity = requests[0].Quantity,
                    Total = requests[0].Total,
                    Stauts = false,
                };
                await this.MovieContext.BookingTickets.AddAsync(bookingTicket);

            }
            else
            {
                foreach (var bookingticket in requests)
                {
                    var bookingTicket = new BookingTicket()
                    {
                        BookingId = id,
                        TicketId = bookingticket.TicketId,
                        Quantity= bookingticket.Quantity,
                        Total= bookingticket.Total,
                        Stauts = false
                    };
                    await this.MovieContext.BookingTickets.AddAsync(bookingTicket);
                }
            }
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
                              OrderId = b.OrderId,
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

        public IQueryable<BookingHistoryViewModel> GetBookingByUserId(Guid userId)
        {
            var booking = from b in this.MovieContext.Bookings
                          join scr in this.MovieContext.Screenings on b.ScreeningId equals scr.Id
                          join au in this.MovieContext.Users on b.AppUserId equals au.Id
                          join p in this.MovieContext.PaymentMethods on b.PaymentMethodId equals p.Id
                          join cp in this.MovieContext.Coupons on b.CouponId equals cp.Id
                          join m in this.MovieContext.Movies on scr.MovieId equals m.Id
                          join aud in this.MovieContext.Auditoriums on scr.AuditoriumId equals aud.Id
                          join c in this.MovieContext.Cinemas on aud.CinemaId equals c.Id
                          where b.AppUserId == userId
                          select new BookingHistoryViewModel()
                          {
                              QrContent = EncryptorHelper.EncryptString( _configuration["QrSerect"], b.OrderId, _configuration["QrVector"]),
                              MovieName = m.Name,
                              MovieImage = m.ImageBackground!,
                              AuditoriumName = aud.Name,
                              CinemaName = c.Name,
                              Total = b.Total,
                              BookingDate = b.CreatedDate,
                              OrderId = b.OrderId,
                              ShowTime = scr.ShowTime,
                              BookingCombo = (from bcb in this.MovieContext.BookingCombos
                                        join cb in this.MovieContext.Combos on bcb.ComboId equals cb.Id
                                        where b.Id == bcb.BookingId
                                        select new BookingComboViewModel()
                                        {
                                            Name = cb.Name,
                                            Price = cb.Price.Value,
                                            Quantity = bcb.Quantity
                                        }).ToList(),
                              BookingTicket = (from bt in this.MovieContext.BookingTickets
                                         join t in this.MovieContext.Tickets on bt.TicketId equals t.Id
                                         where b.Id == bt.BookingId
                                         select new BookingTicketViewModel()
                                         {
                                             Name = t.Name,
                                             Quantity = bt.Quantity,
                                             Price = t.Price
                                         }).ToList(),
                              BookingSeats = (from bs in this.MovieContext.SeatReserveds
                                             join sn in this.MovieContext.SeatNos on bs.SeatNoId equals sn.Id
                                             join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                                             where b.Id == bs.BookingId
                                             select s.SeatId).ToList()
                          };

            return booking.AsQueryable();
        }

        public IQueryable<BookingHistoryViewModel> GetBookingDetailByQrCode(string qrContent)
        {
            var orderId = EncryptorHelper.DecryptString(_configuration["QrSerect"], qrContent, _configuration["QrVector"]);
            var booking = from b in this.MovieContext.Bookings
                          join scr in this.MovieContext.Screenings on b.ScreeningId equals scr.Id
                          join au in this.MovieContext.Users on b.AppUserId equals au.Id
                          join p in this.MovieContext.PaymentMethods on b.PaymentMethodId equals p.Id
                          join cp in this.MovieContext.Coupons on b.CouponId equals cp.Id
                          join m in this.MovieContext.Movies on scr.MovieId equals m.Id
                          join aud in this.MovieContext.Auditoriums on scr.AuditoriumId equals aud.Id
                          join c in this.MovieContext.Cinemas on aud.CinemaId equals c.Id
                          where b.OrderId == orderId
                          select new BookingHistoryViewModel()
                          { 
                              QrContent = HashHelper.HmacSha256(b.OrderId!, _configuration["QrSerect"]),
                              MovieName = m.Name,
                              MovieImage = m.ImageBackground!,
                              AuditoriumName = aud.Name,
                              CinemaName = c.Name,
                              Total = b.Total,
                              Status = b.Stauts!.Value,
                              BookingDate = b.CreatedDate,
                              OrderId = b.OrderId!,
                              ShowTime = scr.ShowTime,
                              BookingCombo = (from bcb in this.MovieContext.BookingCombos
                                              join cb in this.MovieContext.Combos on bcb.ComboId equals cb.Id
                                              where b.Id == bcb.BookingId
                                              select new BookingComboViewModel()
                                              {
                                                  Name = cb.Name,
                                                  Price = cb.Price.Value,
                                                  Quantity = bcb.Quantity
                                              }).ToList(),
                              BookingTicket = (from bt in this.MovieContext.BookingTickets
                                               join t in this.MovieContext.Tickets on bt.TicketId equals t.Id
                                               where b.Id == bt.BookingId
                                               select new BookingTicketViewModel()
                                               {
                                                   Name = t.Name,
                                                   Quantity = bt.Quantity,
                                                   Price = t.Price
                                               }).ToList(),
                              BookingSeats = (from bs in this.MovieContext.SeatReserveds
                                              join sn in this.MovieContext.SeatNos on bs.SeatNoId equals sn.Id
                                              join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                                              where b.Id == bs.BookingId
                                              select s.SeatId).ToList()
                          };

            return booking.AsQueryable();
        }

        public IQueryable<BookingHistoryViewModel> GetBookingDetailByUserId(int id, Guid userId)
        {
            var booking = from b in this.MovieContext.Bookings
                          join scr in this.MovieContext.Screenings on b.ScreeningId equals scr.Id
                          join au in this.MovieContext.Users on b.AppUserId equals au.Id
                          join p in this.MovieContext.PaymentMethods on b.PaymentMethodId equals p.Id
                          join cp in this.MovieContext.Coupons on b.CouponId equals cp.Id
                          join m in this.MovieContext.Movies on scr.MovieId equals m.Id
                          join aud in this.MovieContext.Auditoriums on scr.AuditoriumId equals aud.Id
                          join c in this.MovieContext.Cinemas on aud.CinemaId equals c.Id
                          where b.Id == id && b.AppUserId == userId
                          select new BookingHistoryViewModel()
                          {
                              QrContent = EncryptorHelper.EncryptString(_configuration["QrSerect"], b.OrderId, _configuration["QrVector"]),
                              MovieName = m.Name,
                              MovieImage = m.ImageBackground!,
                              AuditoriumName = aud.Name,
                              CinemaName = c.Name,
                              Total = b.Total,
                              BookingDate = b.CreatedDate,
                              OrderId = b.OrderId,
                              ShowTime = scr.ShowTime,
                              BookingCombo = (from bcb in this.MovieContext.BookingCombos
                                              join cb in this.MovieContext.Combos on bcb.ComboId equals cb.Id
                                              where b.Id == bcb.BookingId
                                              select new BookingComboViewModel()
                                              {
                                                  Name = cb.Name,
                                                  Price = cb.Price.Value,
                                                  Quantity = bcb.Quantity
                                              }).ToList(),
                              BookingTicket = (from bt in this.MovieContext.BookingTickets
                                               join t in this.MovieContext.Tickets on bt.TicketId equals t.Id
                                               where b.Id == bt.BookingId
                                               select new BookingTicketViewModel()
                                               {
                                                   Name = t.Name,
                                                   Quantity = bt.Quantity,
                                                   Price = t.Price
                                               }).ToList(),
                              BookingSeats = (from bs in this.MovieContext.SeatReserveds
                                              join sn in this.MovieContext.SeatNos on bs.SeatNoId equals sn.Id
                                              join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                                              where b.Id == bs.BookingId
                                              select s.SeatId).ToList()
                          };

            return booking.AsQueryable();
        }

        public async Task<Booking> SaveMomoPayment(Booking entity)
        {
            var booking = await this.MovieContext.Bookings.AddAsync(entity);
            return booking.Entity;
        }

        public async Task<Booking> UpdatePaymentStatus(string orderId, bool status)
        {
            var booking = await this.MovieContext.Bookings.Where(x => x.OrderId == orderId).FirstOrDefaultAsync();

            if (booking == null) throw new BookingMovieException("Không tìm thấy đơn đặt hàng với id: " + orderId);
            booking.Stauts = status;

            this.MovieContext.Bookings.Attach(booking);
            this.MovieContext.Entry(booking).Property(x => x.Stauts).IsModified = true;
            return booking;
        }



       
    }
}