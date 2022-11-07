using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.MovieVM
{

    public class MoviePagingViewModel
    {
        public string[] directors { get; set; } = null!;
        public string[] categories { get; set; } = null!;
        public string[] producers { get; set; } = null!;
    }
}
