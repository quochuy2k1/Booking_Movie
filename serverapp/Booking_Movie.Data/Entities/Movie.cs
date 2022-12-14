using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class Movie : Auditable
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string? Content { get; set; }
        public string? VideoTrailer { get; set; } 
        public string? ImagePreview { get; set; } 
        public string? ImageBackground { get; set; } 

        public string NationalityId { get; set; } = null!;
        public Guid ProducerId { get; set; }

        public Nationality Nationality { get; set; } = null!;
        public Producer Producer { get; set; } = null!;

        public ICollection<MovieDirector> MovieDirectors { get; set; } = null!;
        public ICollection<MovieCategory> MovieCategories { get; set; } = null!;
        public ICollection<Cast> Casts { get; set; } = null!;
        public ICollection<Screening> Screenings { get; set; } = null!;
    }
}