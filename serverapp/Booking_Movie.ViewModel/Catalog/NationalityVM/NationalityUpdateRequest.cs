using Booking_Movie.ViewModel.Abstract;
using Microsoft.AspNetCore.Http;

namespace Booking_Movie.ViewModel.Catalog.NationalityVM
{
    public class NationalityUpdateRequest
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public bool FlagActor { get; set; }
        public bool FlagDirector { get; set; }
        public bool FlagProducer { get; set; }
        public bool FlagMovie { get; set; }

    }
}