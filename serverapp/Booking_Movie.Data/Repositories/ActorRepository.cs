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
        Task<ActorImage> CreateActorImage(ActorImage ActorImage); 
        void UpdateActorImage(ActorImage ActorImage);
        Task<List<ActorImage>?> DeleteActorImageAsync(int[] idListid);
        IQueryable<ActorImage>? GetActorImageDetail(int id, Guid actorId);
        IQueryable<ActorImage>? GetAllActorImage(Guid actorId);
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
                    NationalityId = this.MovieContext.Nationalities.FirstOrDefault(n => n.Id == actor.NationalityId)!.Name,
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

        public async Task<ActorImage> CreateActorImage(ActorImage ActorImage)
        {
            var actorImage = await this.MovieContext.ActorImages.AddAsync(ActorImage);
            return actorImage.Entity;
        }

        public void UpdateActorImage(ActorImage ActorImage)
        {
            this.MovieContext.ActorImages.Attach(ActorImage);
            this.MovieContext.Entry(ActorImage).State = EntityState.Modified;
        }

        public IQueryable<ActorImage>? GetActorImageDetail(int id, Guid actorId)
        {
            var actorImage = this.MovieContext.ActorImages
                                        .Where(x => x.Id == id && x.ActorId == actorId)
                                        .AsQueryable();
            return actorImage;
        }

        public IQueryable<ActorImage>? GetAllActorImage(Guid actorId)
        {
            var actorImage = this.MovieContext.ActorImages
                                         .Where(x => x.ActorId == actorId).AsQueryable();
            return actorImage;
        }

        public async Task<List<ActorImage>?> DeleteActorImageAsync(int[] idList)
        {
            try
            {
                List<ActorImage> entities = new List<ActorImage>();
                foreach (var id in idList)
                {
                    var entity = await this.MovieContext.ActorImages.FindAsync(id);
                    if (!Equals(entity, null))
                    {
                        entities.Add(entity);
                        this.MovieContext.ActorImages.Remove(entity);
                    }
                }

                return entities.Any() ? entities : null;

            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}