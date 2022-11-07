using Booking_Movie.Data.EF;

namespace Booking_Movie.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private BookingMovieContext movieContext;

        public UnitOfWork(IDbFactory dbFactory, BookingMovieContext movieContext)
        {
            this.movieContext = movieContext;
            this.dbFactory = dbFactory;
        }

        public BookingMovieContext MovieContext
        {
            get { return movieContext ??= dbFactory.InitContext(); }
        }

        public async Task<bool> Commit()
        {
            return await movieContext.SaveChangesAsync() > 0;
        }
    }
}