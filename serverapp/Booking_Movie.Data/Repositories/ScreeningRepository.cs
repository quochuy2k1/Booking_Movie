using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Microsoft.EntityFrameworkCore;

namespace Booking_Movie.Data.Repositories
{
    public interface IScreeningRepository : IRepository<Screening>
    {
        IQueryable<Screening> GetByShowTime(int movieId, int auditoriumId, string showTimeId);
        Task<Screening?> DeleteAllShowTimeScreening(int screeningGroupedId);
        Task<List<Screening>?> GetByScreeningGrouped(int screeningGroupedId);
    }
    public class ScreeningRepository : RepositoryBase<Screening>, IScreeningRepository
    {
        public ScreeningRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {

        }

        public async Task<List<Screening>?> GetByScreeningGrouped(int screeningGroupedId)
        {
            var screeningGrouped = await this.MovieContext.Screenings
                           .Where(x => x.Id == screeningGroupedId)
                           .FirstOrDefaultAsync();
            if (screeningGrouped == null)
            {
                return null;
            }
            List<Screening>? screening = await this.MovieContext.Screenings
                            .Where(x => x.MovieId == screeningGrouped.MovieId && x.AuditoriumId == screeningGrouped.AuditoriumId)
                            .ToListAsync();
            if (screening == null)
            {
                return null;
            }

            return screening;

        }

        public async Task<Screening?> DeleteAllShowTimeScreening(int screeningGroupedId)
        {
            var screeningGrouped = await this.MovieContext.Screenings
                            .Where(x => x.Id == screeningGroupedId)
                            .FirstOrDefaultAsync();
            if (screeningGrouped == null)
            {
                return null;
            }
            List<Screening>? screening = await this.MovieContext.Screenings
                            .Where(x => x.MovieId == screeningGrouped.MovieId && x.AuditoriumId == screeningGrouped.AuditoriumId)
                            .ToListAsync();
            if (screening == null)
            {
                return null;
            }
            MovieContext.Screenings.RemoveRange(screening);
            return screeningGrouped;
        }

        public IQueryable<Screening> GetByShowTime(int movieId, int auditoriumId, string showTimeId)
        {
            var result = (from s in this.MovieContext.Screenings
                          join st in this.MovieContext.ShowTimes on s.ShowTimeId equals st.Id
                          where s.MovieId == movieId && s.AuditoriumId == auditoriumId && s.ShowTimeId == showTimeId
                          select s);

            return result;
        }
    }
}