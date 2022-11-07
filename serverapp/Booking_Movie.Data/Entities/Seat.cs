namespace Booking_Movie.Data.Entities
{
    public class Seat
    {
        //public string ID { get; set; } = null!;
        public string SeatId { get; set; } = null!;
        public string Row { get; set; } = null!;
        public int Number { get; set; }

        public ICollection<SeatNo> SeatNos { get; set; } = null!;
    }
}