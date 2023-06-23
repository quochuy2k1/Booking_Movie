namespace Booking_Movie.ViewModel.Catalog.TicketVM
{
    public class TicketViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? TicketTypeId { get; set; }
        public string? TicketTypeName { get; set; } = null!;
        public string? Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string? MovieName { get; set; }
        public int? MovieId { get; set; }
        public string? ValidityDateFromId { get; set; }
        public string? ValidityDateToId { get; set; }
        public DateTime? ValidityDateFrom { get; set; }
        public DateTime? ValidityDateTo { get; set; }
    }


}