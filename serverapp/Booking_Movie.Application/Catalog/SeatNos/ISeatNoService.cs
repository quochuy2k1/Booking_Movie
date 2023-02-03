using Booking_Movie.ViewModel.Catalog.SeatNoVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.SeatNos
{
    public interface ISeatNoService
    {
        Task<SeatNoViewModel?> UpdateStatus(int id, bool status);
    }
}
