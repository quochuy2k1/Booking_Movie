using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.ViewModel.Catalog.ActorVM
{
    public class ActorImageUpdateRequest
    {
        public IFormFile? Image { get; set; }
        public bool? IsDefault { get; set; }
        public int? SortOrder { get; set; }
    }
}
