using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Utilities.Common;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.BookingComboVM;
using Booking_Movie.ViewModel.Catalog.BookingTicketVM;
using Booking_Movie.ViewModel.Catalog.BookingVM;
using Booking_Movie.ViewModel.Catalog.ChartReportVM;
using Booking_Movie.ViewModel.Catalog.ReportVM.BookingReportVM;
using Booking_Movie.ViewModel.Catalog.SeatReservedVM;
using Booking_Movie.ViewModel.Utils.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Booking_Movie.Data.Repositories
{
    public interface IBookingRepository : IRepository<Booking>
    {
        IQueryable<BookingViewModel> GetAllBooking();
        IQueryable<BookingViewModel> GetAllPagingBookingAdmin(GetBookingPagingRequest? request);

        IQueryable<BookingHistoryViewModel> GetBookingByUserId(Guid userId);

        IQueryable<BookingHistoryViewModel> GetBookingDetailByUserId(int id, Guid userId);

        IQueryable<BookingHistoryViewModel> GetBookingDetailByQrCode(string qrContent);

        Task<Booking> SaveMomoPayment(Booking entity);

        Task AddBookingTicket(int id, CreateBookingTicketRequest[] requests);

        Task AddBookingCombo(int id, CreateBookingComboRequest[] requests);

        Task<List<int>?> AddBookingSeatReserved(int id, CreateSeatReservedRequest[] requests);

        Task<Booking> UpdatePaymentStatus(string orderId, bool status);

        #region ReportChart

        ScanningRateChartReportViewModel ScanningRateReportChart(ScanningRateChartReportRequest? request);

        #endregion ReportChart
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
                    Status = false,
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
                        Status = false,
                        
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
                    BookingId = id,
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
                        SeatNoId = seatNo.SeatNoId
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
                    ScreeningTicketId = 1,
                    Quantity = requests[0].Quantity,
                    Total = requests[0].Total,
                    Status = false,
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
                        ScreeningTicketId = 1,
                        Quantity = bookingticket.Quantity,
                        Total = bookingticket.Total,
                        Status = false
                    };
                    await this.MovieContext.BookingTickets.AddAsync(bookingTicket);
                }
            }
        }

        public IQueryable<BookingViewModel> GetAllBooking()
        {
            var booking = from b in this.MovieContext.Bookings
                          join scr in this.MovieContext.Screenings on b.ScreeningId equals scr.Id
                          join stt in this.MovieContext.ShowTimes on scr.ShowTimeId equals stt.Id
                          join au in this.MovieContext.Users on b.AppUserId equals au.Id
                          join p in this.MovieContext.PaymentMethods on b.PaymentMethodId equals p.Id
                          join cp in this.MovieContext.Coupons on b.CouponId equals cp.Id into couponJoin
                          from cp in couponJoin.DefaultIfEmpty()
                          join m in this.MovieContext.Movies on scr.MovieId equals m.Id
                          join aud in this.MovieContext.Auditoriums on scr.AuditoriumId equals aud.Id
                          join ci in this.MovieContext.Cinemas on aud.CinemaId equals ci.Id
                          select new BookingViewModel()
                          {
                              Id = b.Id,
                              CinemaId = ci.Id,
                              MovieId = m.Id,
                              Total = b.Total,
                              CreatedDate = b.CreatedDate,
                              CouponId = b.CouponId,
                              PaymentMethod = p.Name,
                              OrderId = b.OrderId,
                              ShowTime = stt.Time,
                              flagScanner = b.Status!.Value,
                              UserFullName = au.FirstName + " " + au.LastName,
                              Combos = (from bcb in this.MovieContext.BookingCombos
                                        join cb in this.MovieContext.Combos on bcb.ComboId equals cb.Id
                                        where b.Id == bcb.BookingId
                                        select cb.Name).ToArray(),
                              Tickets = (from bt in this.MovieContext.BookingTickets
                                         join t in this.MovieContext.Tickets on bt.TicketId equals t.Id
                                         where b.Id == bt.BookingId
                                         select t.Name).ToArray(),
                              SeatRevered = (from bs in this.MovieContext.SeatReserveds
                                             join sn in this.MovieContext.SeatNos on bs.SeatNoId equals sn.Id
                                             join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                                             where b.Id == bs.BookingId
                                             select s.Row + s.Number).ToArray()
                          };

            return booking.AsQueryable();
        }
        public IQueryable<BookingViewModel> GetAllPagingBookingAdmin(GetBookingPagingRequest? request)
        {
            var booking = from b in this.MovieContext.Bookings
                          join scr in this.MovieContext.Screenings on b.ScreeningId equals scr.Id
                          join stt in this.MovieContext.ShowTimes on scr.ShowTimeId equals stt.Id
                          join au in this.MovieContext.Users on b.AppUserId equals au.Id
                          join p in this.MovieContext.PaymentMethods on b.PaymentMethodId equals p.Id
                          join cp in this.MovieContext.Coupons on b.CouponId equals cp.Id into couponJoin
                          from cp in couponJoin.DefaultIfEmpty()
                          join m in this.MovieContext.Movies on scr.MovieId equals m.Id
                          join aud in this.MovieContext.Auditoriums on scr.AuditoriumId equals aud.Id
                          join ci in this.MovieContext.Cinemas on aud.CinemaId equals ci.Id
                          // filter
                          where (request.MovieId == null || m.Id == request.MovieId) &&
                                 (request.CinemaId == null || ci.Id == request.CinemaId)
                          select new BookingViewModel()
                          {
                              Id = b.Id,
                              CinemaId = ci.Id,
                              MovieId = m.Id,
                              Total = b.Total,
                              CreatedDate = b.CreatedDate,
                              ShowDate = b.ShowDate,
                              CouponId = b.CouponId,
                              PaymentMethod = p.Name,
                              OrderId = b.OrderId,
                              ShowTime = stt.Time,
                              flagScanner = b.Status!.Value,
                              UserFullName = au.FirstName + " " + au.LastName,
                              Combos = (from bcb in this.MovieContext.BookingCombos
                                        join cb in this.MovieContext.Combos on bcb.ComboId equals cb.Id
                                        where b.Id == bcb.BookingId
                                        select cb.Name).ToArray(),
                              Tickets = (from bt in this.MovieContext.BookingTickets
                                         join t in this.MovieContext.Tickets on bt.TicketId equals t.Id
                                         join tt in this.MovieContext.TicketTypes on t.TicketTypeId equals tt.Id
                                         where b.Id == bt.BookingId
                                         select tt.Name).ToArray(),
                              SeatRevered = (from bs in this.MovieContext.SeatReserveds
                                             join sn in this.MovieContext.SeatNos on bs.SeatNoId equals sn.Id
                                             join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                                             where b.Id == bs.BookingId
                                             select s.Row + s.Number).ToArray()
                          };

            return booking.AsQueryable();
        }

        public IQueryable<BookingHistoryViewModel> GetBookingByUserId(Guid userId)
        {
            var booking = from b in this.MovieContext.Bookings
                          join scr in this.MovieContext.Screenings on b.ScreeningId equals scr.Id
                          join stt in this.MovieContext.ShowTimes on scr.ShowTimeId equals stt.Id
                          join au in this.MovieContext.Users on b.AppUserId equals au.Id
                          join p in this.MovieContext.PaymentMethods on b.PaymentMethodId equals p.Id
                          join cp in this.MovieContext.Coupons on b.CouponId equals cp.Id into couponJoin
                          from cp in couponJoin.DefaultIfEmpty()
                          join m in this.MovieContext.Movies on scr.MovieId equals m.Id
                          join aud in this.MovieContext.Auditoriums on scr.AuditoriumId equals aud.Id
                          join c in this.MovieContext.Cinemas on aud.CinemaId equals c.Id
                          where b.AppUserId == userId
                          orderby b.CreatedDate descending
                          select new BookingHistoryViewModel()
                          {
                              QrContent = EncryptorHelper.EncryptString(_configuration["QrSerect"], b.OrderId, _configuration["QrVector"]),
                              MovieName = m.Name,
                              MovieImage = m.ImageBackground!,
                              AuditoriumName = aud.Name,
                              CinemaName = c.Name,
                              Total = b.Total,
                              BookingDate = b.CreatedDate,
                              ShowDate = b.ShowDate.Value.ToLocalTime(),
                              OrderId = b.OrderId,
                              ShowTime = stt.Time,
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
                                               join tt in this.MovieContext.TicketTypes on t.TicketTypeId equals tt.Id
                                               where b.Id == bt.BookingId
                                               select new BookingTicketViewModel()
                                               {
                                                   Name = t.Name,
                                                   Quantity = bt.Quantity,
                                                   Price = t.Price,
                                                   TicketTypeName = tt.Name
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
            var booking = this.MovieContext.Bookings
                .Join(this.MovieContext.Screenings, b => b.ScreeningId, scr => scr.Id, (b, scr) => new { b, scr })
    .Join(this.MovieContext.ShowTimes, bs => bs.scr.ShowTimeId, stt => stt.Id, (bs, stt) => new { bs.b, bs.scr, stt })
    .Join(this.MovieContext.Users, bsstt => bsstt.b.AppUserId, au => au.Id, (bsstt, au) => new { bsstt.b, bsstt.scr, bsstt.stt, au })
    .Join(this.MovieContext.PaymentMethods, bssstt => bssstt.b.PaymentMethodId, p => p.Id, (bssstt, p) => new { bssstt.b, bssstt.scr, bssstt.stt, bssstt.au, p })
    .GroupJoin(this.MovieContext.Coupons, bssstt => bssstt.b.CouponId, cp => cp.Id, (bssstt, coupon) => new { bssstt.b, bssstt.scr, bssstt.stt, bssstt.au, bssstt.p, coupon })
    .SelectMany(bsssttcp => bsssttcp.coupon.DefaultIfEmpty(), (bsssttcp, cp) => new { bsssttcp.b, bsssttcp.scr, bsssttcp.stt, bsssttcp.au, bsssttcp.p, cp })
    .Join(this.MovieContext.Movies, bssspcp => bssspcp.scr.MovieId, m => m.Id, (bssspcp, m) => new { bssspcp.b, bssspcp.scr, bssspcp.stt, bssspcp.au, bssspcp.p, bssspcp.cp, m })
    .Join(this.MovieContext.Auditoriums, bsssppcm => bsssppcm.scr.AuditoriumId, aud => aud.Id, (bsssppcm, aud) => new { bsssppcm.b, bsssppcm.scr, bsssppcm.stt, bsssppcm.au, bsssppcm.p, bsssppcm.cp, bsssppcm.m, aud })
    .Join(this.MovieContext.Cinemas, bsssaud => bsssaud.aud.CinemaId, c => c.Id, (bsssaud, c) => new { bsssaud.b, bsssaud.scr, bsssaud.stt, bsssaud.au, bsssaud.p, bsssaud.cp, bsssaud.m, bsssaud.aud, c })
                .Where(b => b.b.OrderId == orderId)
                
                .Select(bsssaudc => new BookingHistoryViewModel()
                {
                    QrContent = HashHelper.HmacSha256(bsssaudc.b.OrderId!, _configuration["QrSerect"]),
                    MovieName = bsssaudc.m.Name,
                    MovieImage = bsssaudc.m.ImageBackground!,
                    AuditoriumName = bsssaudc.aud.Name,
                    CinemaName = bsssaudc.c.Name,
                    CinemaAddress = bsssaudc.c.Address,
                    Total = bsssaudc.b.Total,
                    Status = bsssaudc.b.Status!.Value,
                    BookingDate = bsssaudc.b.CreatedDate,
                    OrderId = bsssaudc.b.OrderId!,
                    ShowTime = bsssaudc.stt.Time,
                    ShowDate = bsssaudc.b.ShowDate,
                    BookingCombo = this.MovieContext.BookingCombos
                        .Where(bcb => bcb.BookingId == bsssaudc.b.Id)
                        .Join(this.MovieContext.Combos, bcb => bcb.ComboId, cb => cb.Id, (bcb, cb) => new BookingComboViewModel()
                        {
                            Name = cb.Name,
                            Price = cb.Price.Value,
                            Quantity = bcb.Quantity
                        }).ToList(),
                    BookingTicket = this.MovieContext.BookingTickets
                        .Where(bt => bt.BookingId == bsssaudc.b.Id)
                        .Join(this.MovieContext.Tickets, btst => btst.TicketId, t => t.Id, (btst, t) => new {btst, t})
                        .Join(this.MovieContext.TicketTypes, btsttt => btsttt.t.TicketTypeId, tt => tt.Id, (btsttt, tt) => new BookingTicketViewModel()
                        {
                            Name = btsttt.t.Name,
                            Quantity = btsttt.btst.Quantity,
                            Price = btsttt.t.Price,
                            TicketTypeName = tt.Name,
                        }).ToList(),
                    BookingSeats = this.MovieContext.SeatReserveds
                        .Where(bs => bs.BookingId == bsssaudc.b.Id)
                        .Join(this.MovieContext.SeatNos, bs => bs.SeatNoId, sn => sn.Id, (bs, sn) => new { bs, sn })
                        .Join(this.MovieContext.Seats, bssn => bssn.sn.SeatId, s => s.SeatId, (bssn, s) => s.SeatId).ToList()
                });

            return booking.AsQueryable();
        }

        public IQueryable<BookingHistoryViewModel> GetBookingDetailByUserId(int id, Guid userId)
        {
            var booking = this.MovieContext.Bookings
                .Join(this.MovieContext.Screenings, b => b.ScreeningId, scr => scr.Id, (b, scr) => new { b, scr })
    .Join(this.MovieContext.ShowTimes, bs => bs.scr.ShowTimeId, stt => stt.Id, (bs, stt) => new { bs.b, bs.scr, stt })
    .Join(this.MovieContext.Users, bsstt => bsstt.b.AppUserId, au => au.Id, (bsstt, au) => new { bsstt.b, bsstt.scr, bsstt.stt, au })
    .Join(this.MovieContext.PaymentMethods, bssstt => bssstt.b.PaymentMethodId, p => p.Id, (bssstt, p) => new { bssstt.b, bssstt.scr, bssstt.stt, bssstt.au, p })
    .GroupJoin(this.MovieContext.Coupons, bssstt => bssstt.b.CouponId, cp => cp.Id, (bssstt, coupon) => new { bssstt.b, bssstt.scr, bssstt.stt, bssstt.au, bssstt.p, coupon })
    .SelectMany(bsssttcp => bsssttcp.coupon.DefaultIfEmpty(), (bsssttcp, cp) => new { bsssttcp.b, bsssttcp.scr, bsssttcp.stt, bsssttcp.au, bsssttcp.p, cp })
    .Join(this.MovieContext.Movies, bssspcp => bssspcp.scr.MovieId, m => m.Id, (bssspcp, m) => new { bssspcp.b, bssspcp.scr, bssspcp.stt, bssspcp.au, bssspcp.p, bssspcp.cp, m })
    .Join(this.MovieContext.Auditoriums, bsssppcm => bsssppcm.scr.AuditoriumId, aud => aud.Id, (bsssppcm, aud) => new { bsssppcm.b, bsssppcm.scr, bsssppcm.stt, bsssppcm.au, bsssppcm.p, bsssppcm.cp, bsssppcm.m, aud })
    .Join(this.MovieContext.Cinemas, bsssaud => bsssaud.aud.CinemaId, c => c.Id, (bsssaud, c) => new { bsssaud.b, bsssaud.scr, bsssaud.stt, bsssaud.au, bsssaud.p, bsssaud.cp, bsssaud.m, bsssaud.aud, c })
    .Where(b => b.b.Id == id && b.b.AppUserId == userId)
    

                            .Select(bsssaudc => new BookingHistoryViewModel()
                            {
                                QrContent = EncryptorHelper.EncryptString(_configuration["QrSerect"], bsssaudc.b.OrderId, _configuration["QrVector"]),
                                MovieName = bsssaudc.m.Name,
                                MovieImage = bsssaudc.m.ImageBackground!,
                                AuditoriumName = bsssaudc.aud.Name,
                                CinemaName = bsssaudc.c.Name,
                                Total = bsssaudc.b.Total,
                                BookingDate = bsssaudc.b.CreatedDate,
                                OrderId = bsssaudc.b.OrderId,
                                ShowTime = bsssaudc.stt.Time,
                                ShowDate = bsssaudc.b.ShowDate,
                                BookingCombo = this.MovieContext.BookingCombos
                                    .Where(bcb => bcb.BookingId == bsssaudc.b.Id)
                                    .Join(this.MovieContext.Combos, bcb => bcb.ComboId, cb => cb.Id, (bcb, cb) => new BookingComboViewModel()
                                    {
                                        Name = cb.Name,
                                        Price = cb.Price.Value,
                                        Quantity = bcb.Quantity
                                    }).ToList(),
                                BookingTicket = this.MovieContext.BookingTickets
                                    .Where(bt => bt.BookingId == bsssaudc.b.Id)
                                    .Join(this.MovieContext.Tickets, btst => btst.TicketId, t => t.Id, (btst, t) => new {btst, t})
                                    .Join(this.MovieContext.TicketTypes, btsttt => btsttt.t.TicketTypeId, tt => tt.Id, (btsttt, tt) => new BookingTicketViewModel()
                                    {
                                        Name = btsttt.t.Name,
                                        Quantity = btsttt.btst.Quantity,
                                        Price = btsttt.t.Price,
                                        TicketTypeName = tt.Name,
                                    }).ToList(),
                                BookingSeats = this.MovieContext.SeatReserveds
                                    .Where(bs => bs.BookingId == bsssaudc.b.Id)
                                    .Join(this.MovieContext.SeatNos, bs => bs.SeatNoId, sn => sn.Id, (bs, sn) => new { bs, sn })
                                    .Join(this.MovieContext.Seats, bssn => bssn.sn.SeatId, s => s.SeatId, (bssn, s) => s.SeatId).ToList()
                            });

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
            booking.Status = status;

            this.MovieContext.Bookings.Attach(booking);
            this.MovieContext.Entry(booking).Property(x => x.Status).IsModified = true;
            return booking;
        }

        #region ReportChart

        public ScanningRateChartReportViewModel ScanningRateReportChart(ScanningRateChartReportRequest? request)
        {
            IQueryable<Booking>? queryResult = null;

            var query = this.MovieContext.Bookings;
            double totalBooking = 0;
            double totalNotScanning = 0;
            double totalScanned = 0;

            // filter

            if (request != null && request.Conditional != null && request.Conditional.Value.GetStringValue() == "year")
            {
                queryResult = query
                                .Where(x => x.CreatedDate.Year == DateTime.Now.Year);
            }

            if (request != null && request.Conditional != null && request.Conditional.Value.GetStringValue() == "month")
            {
                queryResult = query
                                .Where(x => x.CreatedDate.Year == DateTime.Now.Year && x.CreatedDate.Month == DateTime.Now.Month);
            }

            totalBooking = queryResult?.Count() ?? 0;
            totalNotScanning = queryResult?.Where(x => x.Status == false)?.Count() ?? 0;
            totalScanned = queryResult?.Where(x => x.Status == true)?.Count() ?? 0;

            return new ScanningRateChartReportViewModel()
            {
                ScannedLabel = "Đã quét",
                NotScanningLabel = "Chưa quét",
                NotScanningRate = (totalNotScanning / totalBooking) * 100,
                ScannedRate = (totalScanned / totalBooking) * 100,
            };
        }

        #endregion ReportChart
    }
}