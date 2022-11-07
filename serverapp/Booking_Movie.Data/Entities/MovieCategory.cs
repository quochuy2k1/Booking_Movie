using Booking_Movie.Data.Abstract;

namespace Booking_Movie.Data.Entities
{
    public class MovieCategory
    {
        public int Id { get; set; }
        public int MovieId { get; set; } 

        public int CategoryId { get; set; }

        public Movie Movie { get; set; } = null!;
        public Category Category { get; set; } = null!;
        
    }
}