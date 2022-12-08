using Booking_Movie.Data.Models;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.SeatVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Auditoriums
{
    public interface IAuditoriumService
    {
        Task<List<SeatInAuditoriumViewModel>?> GetSeatByAuditoriumId(int id);
        Task<List<string>> GetRowOfSeatsByAuditoriumId(int Id);
    }
}
