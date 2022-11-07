using Booking_Movie.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Models
{
    public class MovieDetailsVM
    {
        public string[] directors { get; set; } = null!;
        public string[] categories { get; set; } = null!;
        public string[] actors { get; set; } = null!;
        public Movie movie { get; set; } = null!;
        public string nationality { get; set; } = null!;
    }
}
