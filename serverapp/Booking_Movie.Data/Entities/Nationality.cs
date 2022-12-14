using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Data.Entities
{
    public class Nationality
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public bool? FlagActor { get; set; }
        public bool? FlagDirector { get; set; }
        public bool? FlagProducer { get; set; }
        public bool? FlagMovie { get; set; }

        public ICollection<Actor> Actors { get; set; } = null!;
        public ICollection<Director> Directors { get; set; } = null!;
        public ICollection<Producer> Producers { get; set; } = null!;
        public ICollection<Movie> Movies { get; set; } = null!;

    }
}
