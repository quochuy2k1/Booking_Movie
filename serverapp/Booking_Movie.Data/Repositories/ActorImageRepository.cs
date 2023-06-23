using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;

namespace Booking_Movie.Data.Repositories
{
    public interface IActorImageRepository : IRepository<ActorImage>
    {
    }

    public class ActorImageRepository : RepositoryBase<ActorImage>, IActorImageRepository
    {
        public ActorImageRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }
    }
}