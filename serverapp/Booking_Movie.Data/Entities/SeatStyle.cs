using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Entities
{
    public class SeatStyle
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string? Description { get; set; }
        public ICollection<SeatNo> SeatNos { get; set; } = null!;
    }
}
