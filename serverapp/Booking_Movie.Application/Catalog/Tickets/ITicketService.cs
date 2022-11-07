using Booking_Movie.ViewModel.Catalog.TicketVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Tickets
{
    public interface ITicketService
    {
        Task<List<TicketViewModel>> GetTickets();
    }
}
