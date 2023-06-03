using Booking_Movie.ViewModel.Catalog.ShowTimeVM;
using Booking_Movie.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.ShowTimes
{
    public interface IShowTimeService
    {
        Task<PagedResult<ShowTimeViewModel>> GetAllPaging(GetShowTimePagingRequest pagingRequest);

    }
}
