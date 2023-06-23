using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.TicketVM;

namespace Booking_Movie.Data.Repositories
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        IQueryable<TicketViewModel> GetTicketPagingAdmin(GetTicketPagingAdminRequest request);
        IQueryable<ScreeningTicketViewModel> GetTicketByScreeningId(string screeningId);
    }

    public class TicketRepository : RepositoryBase<Ticket>, ITicketRepository
    {
        public TicketRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
        }

        public IQueryable<TicketViewModel> GetTicketPagingAdmin(GetTicketPagingAdminRequest request)
        {
            var query = from t in this.MovieContext.Tickets
                        join m in this.MovieContext.Movies on t.MovieId equals m.Id
                        join tt in this.MovieContext.TicketTypes on t.TicketTypeId equals tt.Id
                        join dt in this.MovieContext.ShowTimes on t.ValidityDateToId equals dt.Id
                        join df in this.MovieContext.ShowTimes on t.ValidityDateFromId equals df.Id
                        where (request.MovieId == null || m.Id == Convert.ToInt32(request.MovieId.Value))
                        select new TicketViewModel() { 
                            Id = t.Id,
                            Name = t.Name,
                            TicketTypeId = t.TicketTypeId,
                            TicketTypeName = tt.Name,
                            Price = t.Price,
                            Description = t.Description,
                            MovieId = m.Id,
                            MovieName = m.Name,
                            ValidityDateFromId = t.ValidityDateFromId,
                            ValidityDateToId = t.ValidityDateToId,
                            ValidityDateFrom = df.Time,
                            ValidityDateTo = dt.Time,
                        };

            return query;

        }

        public IQueryable<ScreeningTicketViewModel> GetTicketByScreeningId(string screeningId)
        {
            var query = from t in this.MovieContext.Tickets
                        join st in this.MovieContext.ScreeningTickets on t.Id equals st.TicketId
                        join s in this.MovieContext.Screenings on st.ScreeningId equals s.Id
                        where s.Id == Convert.ToInt32(screeningId)
                        select new ScreeningTicketViewModel()
                        {
                            Id = st.Id,
                            Name = t.Name,
                            Price = st.Price,
                        };

            return query;
        }

        public IQueryable<ScreeningTicketViewModel> GetTicketByMovieId(string movieId, DateTime dataTo)
        {
            TimeSpan dateToUTC = dataTo.ToUniversalTime().TimeOfDay;
            TimeSpan dateAfter22UTC = new DateTime(2021, 01, 01, 22, 00, 00).ToUniversalTime().TimeOfDay;

            IQueryable<ScreeningTicketViewModel> query = null;
            if (dateToUTC < dateAfter22UTC)
            {
                query = from t in this.MovieContext.Tickets
                        join tt in this.MovieContext.TicketTypes on t.TicketTypeId equals tt.Id
                        join m in this.MovieContext.Movies on t.MovieId equals m.Id
                        join dt in this.MovieContext.ShowTimes on t.ValidityDateToId equals dt.Id
                        join df in this.MovieContext.ShowTimes on t.ValidityDateFromId equals df.Id
                        where m.Id == Convert.ToInt32(movieId) && dt.Time.TimeOfDay >= dateToUTC && dt.Time.TimeOfDay < dateAfter22UTC
                        select new ScreeningTicketViewModel()
                        {
                            Id = t.Id,
                            Name = t.Name,
                            TicketTypeName = tt.Name,
                            Price = t.Price,
                            
                        };
            }
            else
            {
                query = from t in this.MovieContext.Tickets
                        join m in this.MovieContext.Movies on t.MovieId equals m.Id
                        join dt in this.MovieContext.ShowTimes on t.ValidityDateToId equals dt.Id
                        join df in this.MovieContext.ShowTimes on t.ValidityDateFromId equals df.Id
                        where m.Id == Convert.ToInt32(movieId) && dt.Time.TimeOfDay <= dateAfter22UTC
                        select new ScreeningTicketViewModel()
                        {
                            Id = t.Id,
                            Name = t.Name,
                            Price = t.Price,
                        };
            }

            return query;
        }
    }
}