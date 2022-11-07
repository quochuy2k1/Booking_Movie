using Booking_Movie.Data.EF;

namespace Booking_Movie.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private readonly BookingMovieContext _context;

        public DbFactory(BookingMovieContext context)
        {
            _context = context;
        }

        public BookingMovieContext InitContext()
        {
            return _context;
        }

        protected override void DisposeCore()
        {
            if (_context != null)
                _context.Dispose();
        }
    }
}