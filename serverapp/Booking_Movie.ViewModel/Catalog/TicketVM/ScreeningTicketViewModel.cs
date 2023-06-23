namespace Booking_Movie.ViewModel.Catalog.TicketVM
{
    public class ScreeningTicketViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? TicketTypeName { get; set; }
        public decimal Price { get; set; }
    }
}