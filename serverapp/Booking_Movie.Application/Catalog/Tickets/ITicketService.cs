using Booking_Movie.Data.Entities;
using Booking_Movie.ViewModel.Catalog.TicketVM;
using DevExtreme.AspNet.Data.ResponseModel;
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
        Task<List<ScreeningTicketViewModel>> GetTicketByScreeningId(string id);
        Task<List<ScreeningTicketViewModel>> GetTicketByMovieId(string id, DateTime dateTo);
        Task<Ticket?> Create(TicketCreateRequest request);
        Task<Ticket?> Update(int id, TicketUpdateRequest request);
        Task<LoadResult> GetTicketPagingAdmin(GetTicketPagingAdminRequest request);
    }
}
