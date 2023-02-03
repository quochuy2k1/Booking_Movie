using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.CinemaVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Cinemas
{
    public interface ICinemasService
    {
        Task<List<AuditoriumViewModel>> GetAuditoriumByCinemaId(int cinemaId);
        Task<List<CinemaViewModel>> GetAllCinema();
    }
}
