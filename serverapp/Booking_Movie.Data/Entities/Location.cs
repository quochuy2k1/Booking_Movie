using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Cinema> Cinemas { get; set; } = null!;
    }
}
