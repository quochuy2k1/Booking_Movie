using Booking_Movie.Data.Entities;
using Booking_Movie.ViewModel.Catalog.SeatVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Models
{
    public class SeatInAuditoriumVM
    {
        public string PhysicalName { get; set; } 
        public List<Seat> Seats { get; set; }
    }
}
