using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;

namespace Booking_Movie.Data.Repositories
{
    public interface IMovieCategoryRepository : IRepository<MovieCategory>
    {
    }

    public class MovieCategoryRepository : RepositoryBase<MovieCategory>, IMovieCategoryRepository
    {
        public MovieCategoryRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }
    }
}