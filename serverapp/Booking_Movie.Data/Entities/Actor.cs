using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class Actor : Editable
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = null!;
        public int ViewCount { get; set; }
        public string NationalityId { get; set; } = null!;
        public string? Description { get; set; }
        public float Height { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Image { get; set; }
        public Nationality Nationality { get; set; } = null!;
        public ICollection<Cast> Casts { get; set; } = null!;
        public ICollection<ActorImage> ActorImages { get; set; } = null!;
    }
}