using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.ScreeningVM
{
    public class ScreeningViewModel
    {
        public int Id { get; set; }
        public int? CinemaId { get; set; }
        public string? MovieName { get; set; }
        public int? MovieId { get; set; }
        public string? CinemaName { get; set; } = null!;
        public string? AuditoriumName { get; set; } = null!;
        public int? AuditoriumId { get; set; } = null!;
        public string? ScreeningTypeName { get; set; }
        public int? ScreeningTypeId { get; set; }
        public DateTime[]? ShowTime { get; set; } 
    }
}
