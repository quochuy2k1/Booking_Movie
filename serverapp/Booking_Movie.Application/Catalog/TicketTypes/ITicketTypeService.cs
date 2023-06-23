using Booking_Movie.ViewModel.Catalog.TicketTypeVM;
using DevExtreme.AspNet.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.TicketTypes
{
    public interface ITicketTypeService
    {
        Task<LoadResult> GetTicketTypePagingAdmin(GetTicketTypePagingAdminRequest request);
    }
}
