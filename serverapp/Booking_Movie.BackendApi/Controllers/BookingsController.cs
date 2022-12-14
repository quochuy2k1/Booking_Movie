using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Application.Catalog.Bookings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public BookingsController(IBookingService bookingService, IWebHostEnvironment webHostEnvironment)
        {
            _bookingService = bookingService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("get-all-booking")]
        public async Task<IActionResult> GetAllBooking()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var bookings = await _bookingService.GetAllBooking();
                return Ok(bookings);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
    }

}
