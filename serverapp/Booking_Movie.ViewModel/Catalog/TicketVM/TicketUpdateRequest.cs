namespace Booking_Movie.ViewModel.Catalog.TicketVM
{
    public class TicketUpdateRequest
    {
        public string? Name { get; set; }
        public int? TicketTypeId { get; set; }
        public decimal? Price { get; set; }
        public int? MovieId { get; set; }
        public string? ValidityDateFromId { get; set; } = null!;
        public string? ValidityDateToId { get; set; } = null!;
        public string? Description { get; set; }
    }

    public class DXTicketUpdateRequest
    {
        public int? Key { get; set; }
        public TicketUpdateRequest? Values { get; set; }
    }
}