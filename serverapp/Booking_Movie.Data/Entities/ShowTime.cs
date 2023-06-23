using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Entities
{
    public class ShowTime
    {
        public string Id { get; set; } = null!;
        public DateTime Time { get; set; }
        
        public ICollection<Screening> Screenings { get; set; }
        public ICollection<Ticket> ValidityDateFroms { get; set; }
        public ICollection<Ticket> ValidityDateTos { get; set; }
    }
}
