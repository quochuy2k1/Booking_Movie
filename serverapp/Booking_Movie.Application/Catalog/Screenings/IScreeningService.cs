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
        Task<ScreeningViewModel> GetByShowTime(int movieId, int auditoriumId, string showTimeId);
        Task<ScreeningViewModel> GetById(int id);
        Task<bool?> AddNew(ScreeningCreateRequest request);
        Task<bool> Update(int screeningGroupedId, ScreeningUpdateRequest request);
        Task<List<int>?> Delete(int[] id);
    }
}
