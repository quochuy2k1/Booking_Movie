using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Entities
{
    public class MovieDirector
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Guid DirectorId { get; set; }

        public Director Director { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
    }
}
