using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;

namespace Booking_Movie.Data.Repositories
{
    public interface ICimemaRepository: IRepository<Cinema>
    {
        
        public IQueryable<Auditorium?> GetAuditoriumByCinemaId(int cinemaId);
    }
    public class CimemaRepository : RepositoryBase<Cinema>, ICimemaRepository
    {
        public CimemaRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public IQueryable<Auditorium?> GetAuditoriumByCinemaId(int cinemaId)
        {
            var auditoriums = from au in this.MovieContext.Auditoriums
                              join c in this.MovieContext.Cinemas on au.CinemaId equals c.Id
                              where c.Id == cinemaId
                              select au;

            return auditoriums;
        }
    }
}