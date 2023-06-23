using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;

namespace Booking_Movie.Data.Repositories
{
    public interface IShowTimeRepository : IRepository<ShowTime>
    {
    }

    public class ShowTimeRepository : RepositoryBase<ShowTime>, IShowTimeRepository
    {
        public ShowTimeRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }
    }
}