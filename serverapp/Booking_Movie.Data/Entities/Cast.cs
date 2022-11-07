namespace Booking_Movie.Data.Entities
{
    public class Cast
    {
        public int Id { get; set; }

        public Guid ActorId { get; set; }
        public int MovieId { get; set; }

        public Actor Actor { get; set; } = null!;
        public Movie Movie { get; set; } = null!;
    }
}