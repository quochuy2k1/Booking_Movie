using Booking_Movie.Data.Entities;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Screenings
{
    public interface IScreeningService
    {
        Task<ScreeningViewModel> GetById(int id);
        Task<Screening?> AddNew(ScreeningCreateRequest request);
        Task<bool> Update(int id, ScreeningUpdateRequest request);
        Task<List<int>?> Delete(int[] id);
    }
}
