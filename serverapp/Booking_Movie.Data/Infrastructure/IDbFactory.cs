using Booking_Movie.Data.EF;

namespace Booking_Movie.Data.Infrastructure
{
    public interface IDbFactory
    {
        BookingMovieContext InitContext();
    }
}