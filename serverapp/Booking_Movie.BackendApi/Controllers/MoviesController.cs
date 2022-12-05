using Booking_Movie.Application.Catalog.Movies;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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

        [HttpPost("create")]
        //[Authorize(Roles = "Admin")]
        [RequestSizeLimit(50 * 1024 * 1024)]
        [RequestFormLimits(MultipartBodyLengthLimit = 50 * 1024 * 1024)]
        public async Task<IActionResult> Create([FromForm] MovieCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var host = $"{Request.Scheme}://{Request.Host}";
            var movieId = await _movieService.Create(request);
            if (movieId == null) return BadRequest();

            var movie_created = await _movieService.GetById(movieId.Value, host);
            return Ok(movie_created);
        }

        [HttpPost("add-movie-categories/{Id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddMovieCategories(int Id, [FromForm] int[] categoriesId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var isAddSuccessful = await _movieService.AddMovieCategories(Id, categoriesId);
            if (isAddSuccessful == false) return BadRequest();
            return Ok(isAddSuccessful);
        }

        [HttpPost("add-cast/{Id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddCast(int Id, [FromForm] Guid[] actorsId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var isAddSuccessful = await _movieService.AddCast(Id, actorsId);
            if (isAddSuccessful == false) return BadRequest();
            return Ok(isAddSuccessful);
        }

        [HttpPost("add-movie-director/{Id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddMovieCategory(int Id, [FromForm] Guid[] directorsId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var isAddSuccessful = await _movieService.AddMovieDirector(Id, directorsId);
            if (isAddSuccessful == false) return BadRequest();
            return Ok(isAddSuccessful);
        }
    }
}
