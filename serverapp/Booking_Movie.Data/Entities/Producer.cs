using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class Producer : Editable
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = null!;
        public string NationalityId { get; set; } = null!;

        public string? Image { get; set; }
        public Nationality Nationality { get; set; } = null!;
        public ICollection<Movie> Movies { get; set; } = null!;
    }
}