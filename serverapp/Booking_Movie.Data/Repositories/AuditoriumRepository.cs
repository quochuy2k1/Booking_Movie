using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.SeatVM;

namespace Booking_Movie.Data.Repositories
{
    public interface IAuditoriumRepository: IRepository<Auditorium>
    {
        Task<IQueryable<SeatViewModel>> GetSeatsByAuditoriumId(int Id);
    }
    public class AuditoriumRepository : RepositoryBase<Auditorium>, IAuditoriumRepository
    {
        public AuditoriumRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public Task<IQueryable<SeatViewModel>> GetSeatsByAuditoriumId(int Id)
        {
            var query = from au in this.MovieContext.Auditoriums
                        join sn in this.MovieContext.SeatNos on au.Id equals sn.AuditoriumId
                        join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                        select new SeatViewModel()
                        {
                            Id = s.SeatId,
                            Number = s.Number,
                            Row = s.Row,
                            Status = sn.Stauts
                        };
            return Task.FromResult(query);
        }
    }
}