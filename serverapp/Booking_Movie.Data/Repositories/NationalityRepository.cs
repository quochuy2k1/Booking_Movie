using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;

namespace Booking_Movie.Data.Repositories
{
    public interface INationalityRepository : IRepository<Nationality>
    {
    }

    public class NationalityRepository : RepositoryBase<Nationality>, INationalityRepository
    {
        public NationalityRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }
    }
}