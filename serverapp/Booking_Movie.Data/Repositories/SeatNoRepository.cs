using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.SeatNoVM;
using Microsoft.EntityFrameworkCore;

namespace Booking_Movie.Data.Repositories
{
    public interface ISeatNoRepository : IRepository<SeatNo>
    {
        Task<SeatNo?> UpdateStatus(int id, bool status);

        Task<SeatNoViewModel?> GetSeatNoById(int id);
    }

    public class SeatNoRepository : RepositoryBase<SeatNo>, ISeatNoRepository
    {
        public SeatNoRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public async Task<SeatNoViewModel?> GetSeatNoById(int id)
        {
            var seatNo = await this.MovieContext.SeatNos.GroupJoin(
                this.MovieContext.Auditoriums,
                (s) => s.AuditoriumId,
                (a) => a.Id,
                (s, a) => new { seatNo = s, AuditoriumName = a.FirstOrDefault(x => x.Id == s.AuditoriumId)!.Name })
                .GroupJoin(
                this.MovieContext.SeatStyles,
                (s) => s.seatNo.SeatStyleId,
                (a) => a.Id,
                (s, ss) => new { seatNo = s.seatNo, AuditoriumName = s.AuditoriumName, seatStyleName = ss.FirstOrDefault(x => x.Id == s.seatNo.SeatStyleId)!.Name })
                .Where(x => x.seatNo.Id == id).Select(x => new SeatNoViewModel()
                {
                    Id = x.seatNo.Id,
                    AuditoriumName = x.AuditoriumName,
                    SeatStyleName = x.seatStyleName,
                    ColumnIndex = x.seatNo.ColumnIndex,
                    RowIndex = x.seatNo.RowIndex,
                    SeatId = x.seatNo.SeatId
                }).FirstOrDefaultAsync();
            if (seatNo == null) return null;

            return seatNo;
        }

        public async Task<SeatNo?> UpdateStatus(int id, bool status)
        {
            var seatNo = await this.MovieContext.SeatNos.FindAsync(id);
            if (seatNo == null) return null;

            seatNo.Status = status;

            this.MovieContext.SeatNos.Attach(seatNo);
            this.MovieContext.Entry(seatNo).Property(x => x.Status).IsModified = true;
            return seatNo;
        }
    }
}