using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Application.Catalog.Seats;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatsController : ControllerBase
    {
        private readonly ISeatService _seatService;
        private readonly IWebHostEnvironment webHostEnvironment;
    }
}
