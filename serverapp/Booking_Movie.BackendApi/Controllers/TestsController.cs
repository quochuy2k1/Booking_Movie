using Booking_Movie.Application.Catalog.Movies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {

        private readonly IMovieService _movieService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public TestsController(IMovieService movieService, IWebHostEnvironment webHostEnvironment)
        {
            _movieService = movieService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("MovieRevenueReport")]
        public async Task<IActionResult> MovieRevenueReport()
        {
            var result = await _movieService.MovieRevenueReport(null);

            return Ok(result);
        }
    }
}
