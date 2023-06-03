using System.Data.SqlTypes;
using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.SeatNoVM;
using Booking_Movie.ViewModel.Catalog.SeatVM;

namespace Booking_Movie.Data.Repositories
{
    public interface IAuditoriumRepository: IRepository<Auditorium>
    {
        Task<IQueryable<SeatInAuditoriumViewModel>> GetSeatsByAuditoriumId(int Id);
        Task<IQueryable<string>> GetRowOfSeatsByAuditoriumId(int Id);
    }
    public class AuditoriumRepository : RepositoryBase<Auditorium>, IAuditoriumRepository
    {
       
        public AuditoriumRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public Task<IQueryable<SeatInAuditoriumViewModel>> GetSeatsByAuditoriumId(int Id)
        {
            IQueryable<SeatInAuditoriumViewModel> query = (from au in this.MovieContext.Auditoriums
                        join sn in this.MovieContext.SeatNos on au.Id equals sn.AuditoriumId
                        join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                        where au.Id == Id
                        group new { s, SeatNoId = sn.Id, sn.Status, sn.RowIndex, sn.ColumnIndex, sn.SeatStyleId } by s.Row into g
                        select new SeatInAuditoriumViewModel()
                        {
                            PhysicalName = g.Key,
                            Seats = g.Select(x => new SeatNoClientViewModel()
                            {
                                Id = x.s.SeatId,
                                SeatNoId = x.SeatNoId,
                                Number = x.s.Number,
                                Row = x.s.Row,
                                Status = x.Status,
                                RowIndex =x.RowIndex,
                                ColumnIndex =x.ColumnIndex,
                                SeatStyle = x.SeatStyleId,
                            }).ToList()
                        }).OrderBy(x=> x.PhysicalName).AsQueryable();
            
            return Task.FromResult(query);
        }
        
        public Task<IQueryable<string>> GetRowOfSeatsByAuditoriumId(int Id)
        {
            var query = (from au in this.MovieContext.Auditoriums
                        join sn in this.MovieContext.SeatNos on au.Id equals sn.AuditoriumId
                        join s in this.MovieContext.Seats on sn.SeatId equals s.SeatId
                        where au.Id == Id
                        select s.Row).Distinct();
            
            return Task.FromResult(query);
        }
    }
}