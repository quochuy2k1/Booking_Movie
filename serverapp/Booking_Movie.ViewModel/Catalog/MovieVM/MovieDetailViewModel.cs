using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.MovieVM
{
    public class MovieDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Content { get; set; } = null!;
        public string ImagePreview { get; set; } = null!;
        public string VideoTrailer { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public string Producer { get; set; } = null!;

        public string Actors { get; set; } = null!;
        public string Categories { get; set; } = null!;

        public string Directors { get; set; } = null!;
    }
}
