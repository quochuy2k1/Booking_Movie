using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Microsoft.EntityFrameworkCore;

namespace Booking_Movie.Data.Repositories
{
    public interface IActorRepository : IRepository<Actor>
    {
        Task<IEnumerable<ActorViewModel>> GetByNationality(string nationality);

        Task<Actor> UpdateViewCount(Guid id);
    }

    public class ActorRepository : RepositoryBase<Actor>, IActorRepository
    {
        public ActorRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public async Task<IEnumerable<ActorViewModel>> GetByNationality(string nationality)
        {
            var actors = await this.MovieContext.Set<Actor>().Where(actor => actor.NationalityId == nationality)
                .Select(actor => new ActorViewModel()
                {
                    ID = actor.ID,
                    Name = actor.Name,
                    ViewCount = actor.ViewCount,
                    DateOfBirth = actor.DateOfBirth,
                    Height = actor.Height,
                    Image = actor.Image,
                    NationalityId = actor.Nationality.Id,
                }).ToListAsync();

            return actors;
        }

        public async Task<Actor> UpdateViewCount(Guid id)
        {
            var actor = await this.MovieContext.Set<Actor>().FindAsync(id);

            actor!.ViewCount++;
            MovieContext.Attach(actor);
            MovieContext.Entry(actor).Property(x => x.ViewCount).IsModified = true;
            return actor;
        }
    }
}