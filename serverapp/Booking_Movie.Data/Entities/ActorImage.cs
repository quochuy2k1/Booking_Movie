using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Entities
{
    public class ActorImage
    {
        public int Id { get; set; }
        public Guid ActorId { get; set; }
        public string ImagePath { get; set; } = null!;
        public string Caption { get; set; } = null!;
        public bool IsDefault { get; set; } 
        public DateTime DateCreated { get; set; } 
        public int SortOrder { get; set; }
        public long FileSize { get; set; }
        public Actor Actor { get; set; } = null!;
    }
}
