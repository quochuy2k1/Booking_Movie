using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.TicketVM;
using System.Runtime.CompilerServices;

namespace Booking_Movie.Data.Repositories
{
    public interface ITicketRepository:IRepository<Ticket>
    {
        IQueryable<ScreeningTicketViewModel> GetTicketByScreeningId(string  screeningId);
    }
    public class TicketRepository : RepositoryBase<Ticket>, ITicketRepository
    {
        public TicketRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
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
    }
}