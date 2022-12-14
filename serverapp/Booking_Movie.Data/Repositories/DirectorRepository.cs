using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.DirectorVM;
using Microsoft.EntityFrameworkCore;

namespace Booking_Movie.Data.Repositories
{
    public interface IDirectorRepository : IRepository<Director>
    {
        Task<IEnumerable<DirectorViewModel>> GetByNationality(string nationality);

        Task<Director> UpdateViewCount(Guid id);
    }

    public class DirectorRepository : RepositoryBase<Director>, IDirectorRepository
    {
        public DirectorRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public async Task<IEnumerable<DirectorViewModel>> GetByNationality(string nationality)
        {
            var directors = await this.MovieContext.Set<Director>().Include(x=>x.Nationality).Where(director => director.NationalityId == nationality)
                .Select(director => new DirectorViewModel()
                {
                    ID = director.ID,
                    Name = director.Name,
                    ViewCount = director.ViewCount,
                    DateOfBirth = director.DateOfBirth,
                    Height = director.Height!.Value,
                    Image = director.Image,
                    NationalityId = director.Nationality.Id,
                }).ToListAsync();

            return directors;
        }

        public async Task<Director> UpdateViewCount(Guid id)
        {
            var director = await this.MovieContext.Set<Director>().FindAsync(id);

            director!.ViewCount++;
            MovieContext.Attach(director);
            MovieContext.Entry(director).Property(x => x.ViewCount).IsModified = true;
            return director;
        }
    }
}