using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;

namespace Booking_Movie.Data.Repositories
{
    public interface ISeatRepository : IRepository<Seat>
    {
    }

    public class SeatRepository : RepositoryBase<Seat>, ISeatRepository
    {
        public SeatRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }
    }
}