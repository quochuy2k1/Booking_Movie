using Booking_Movie.Data.Entities;
using Booking_Movie.ViewModel.Catalog.ComboVM;
using DevExtreme.AspNet.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Combos
{
    public interface IComboService
    {
        Task<List<ComboViewModel>?> GetCombos();
        Task<LoadResult> GetTicketPagingAdmin(GetComboPagingAdminRequest request);
        Task<Combo?> Create(ComboCreateRequest request);
        Task<Combo?> Update(int id, ComboUpdateRequest request);
    }
}
