using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.ViewModel.Catalog.TicketTypeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Repositories
{
    public interface ITicketTypeRepository : IRepository<TicketType>
    {

    }
    public class TicketTypeRepository : RepositoryBase<TicketType>, IRepository<TicketType>
    {
        public TicketTypeRepository(BookingMovieContext movieContext, IDbFactory dbFactory) : base(movieContext, dbFactory)
        {
           
        }
        public IQueryable<TicketType>? GetTicketTypePagingAdmin(GetTicketTypePagingAdminRequest request)
        {
            var query = this.MovieContext.TicketTypes.Select(x => x);
            return query;
        }

    }
}
