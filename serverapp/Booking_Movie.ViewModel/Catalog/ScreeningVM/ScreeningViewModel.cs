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
        public string? CinemaName { get; set; }
        public string? AuditoriumName { get; set; }
        public int? AuditoriumId { get; set; } 
        public string? ScreeningTypeName { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? ScreeningTypeId { get; set; }
        public List<MovieSchedule>? MovieSchedule { get; set; }
        public List<string>? ShowTimeId { get; set; }
        public string? TimeId { get; set; }
    }

    public class MovieSchedule
    {
        public int Id { get; set; }
        public string ShowTimeId { get; set; }
        public DateTime ShowTime { get; set; }

    }
}
