using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;

namespace Booking_Movie.Data.Repositories
{
    public interface IComboRepository : IRepository<Combo>
    {

    }
    public class ComboRepository : RepositoryBase<Combo>, IComboRepository
    {
        public ComboRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }
    }
}