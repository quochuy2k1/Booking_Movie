using Booking_Movie.Application.Catalog.Movies;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IWebHostEnvironment webHostEnvironment;


        public MoviesController(IMovieService movieService, IWebHostEnvironment webHostEnvironment)
        {
            _movieService = movieService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("paging/")]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetMoviePagingRequest request)
        {
            var host = $"{Request.Scheme}://{Request.Host}";
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var movies = await _movieService.GetAllPaging(request, host);
            return Ok(movies);
        }

         [HttpGet("detail/{id}")]
        public async Task<IActionResult> GetDetail(int id)
        {
            var host = $"{Request.Scheme}://{Request.Host}";
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var movies = await _movieService.GetMovieDetails(id, host);
            return Ok(movies);
        }

        [HttpPatch("update-image-video/{id}")]
        [RequestSizeLimit(50*1024*1024)]
        [RequestFormLimits(MultipartBodyLengthLimit = 50*1024*1024)]
        public async Task<IActionResult> UpdateImage(int id,[FromForm] MovieUpdateImageVideoRequest request)
        {
           
            if(!ModelState.IsValid) return BadRequest(ModelState);
            var movies = await _movieService.UpdateImageVideo(id, request);
            return Ok(movies);
        }

        [HttpGet("{id}/screening")]
        public async Task<IActionResult> GetScreeningByMovieId(int id) { 
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var screenings = await _movieService.GetScreeningByMovieId(id);
            return Ok(screenings);
        }



    }
}
