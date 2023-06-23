using Booking_Movie.ViewModel.Catalog.ScreeningVM;

namespace Booking_Movie.ViewModel.Catalog.TicketVM
{
    public class TicketCreateRequest
    {
        public string Name { get; set; } = null!;
        public int TicketTypeId { get; set; }
        public decimal Price { get; set; }
        public int MovieId { get; set; }
        public string ValidityDateFromId { get; set; } = null!;
        public string ValidityDateToId { get; set; } = null!;
        public string? Description { get; set; }
    }

    public class DXTicketCreateRequest
    {
        public TicketCreateRequest? Values { get; set; }
    }
}