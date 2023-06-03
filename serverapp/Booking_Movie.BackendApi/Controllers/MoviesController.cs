using Booking_Movie.Application.Catalog.Movies;
using Booking_Movie.Utilities.Common;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Booking_Movie.ViewModel.Common;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
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
        
        [HttpPost("paging/admin")]
        public async Task<IActionResult> GetAllPagingAdmin([FromForm]GetMoviePagingAdminRequest request)
        {
            var host = $"{Request.Scheme}://{Request.Host}";
            var sort = Request.Form["sort"];
            var filter = Request.Form["filter"];
            var group = Request.Form["group"];

            if (!String.IsNullOrEmpty(filter))
            {
                request.Filter = JsonConvert.DeserializeObject<IList>(filter);
            }

            if (!String.IsNullOrEmpty(sort))
            {
                request.Sort = JsonConvert.DeserializeObject<SortingInfo[]>(sort);


            }
            if (!String.IsNullOrEmpty(group))
            {
                request.Group = JsonConvert.DeserializeObject<GroupingInfo[]>(group);


            }
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var movies = await _movieService.GetAllPagingAdmin(request, host);
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
        
        [HttpGet("screening")]
        public async Task<IActionResult> GetAllScreening() { 
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var screenings = await _movieService.GetAllScreening();
            return Ok(screenings);
        }

        [HttpPost("screening/paging/")]
        public async Task<IActionResult> GetAllScreeningPagingAdmin([FromForm] GetScreeningPagingRequest request)
        {
            var host = $"{Request.Scheme}://{Request.Host}";
            var sort = Request.Form["sort"];
            var filter = Request.Form["filter"];
            var group = Request.Form["group"];

            if (!String.IsNullOrEmpty(filter))
            {
                request.Filter = JsonConvert.DeserializeObject<IList>(filter);
            }

            if (!String.IsNullOrEmpty(sort))
            {
                request.Sort = JsonConvert.DeserializeObject<SortingInfo[]>(sort);


            }if (!String.IsNullOrEmpty(group))
            {
                request.Group = JsonConvert.DeserializeObject<GroupingInfo[]>(group);


            }
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var screening = await _movieService.GetAllPagingScreeningAdmin(request, host);

            return Ok(screening);
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

            var movie_created = await _movieService.GetMovieDetails(movieId.Value, host);
            return Ok(movie_created);
        }

        [HttpPut("{id}/update")]
        [Authorize(Roles = "Admin")]
        [RequestSizeLimit(50 * 1024 * 1024)]
        [RequestFormLimits(MultipartBodyLengthLimit = 50 * 1024 * 1024)]
        public async Task<IActionResult> Update(int id, [FromForm] MovieUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var movieId = await _movieService.Update(id, request);
                if (movieId == null) return BadRequest();

                var movie_updated = await _movieService.GetMovieDetails(movieId.Value, host);
                return Ok(movie_updated);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
           
        }

        [HttpDelete("del")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromBody] int[] id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var isSuccess = await _movieService.Delete(id);
                if (isSuccess == null) return BadRequest();
                return Ok(isSuccess);

            }
            catch (DbUpdateException)
            {
                
                return StatusCode(500, "Không thể xoá nếu bảng movie còn tham chiếu đến bảng khác. (Danh mục phim, Đạo diễn, Diễn viên). Phải xoá những tham chiếu đến bảng này hết trước khi xoá.");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);

            }

        }


        [HttpPatch("{id}/update-cast")]
        public async Task<IActionResult> UpdateCast(int id, Guid[] actorsId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var isSuccessful = await _movieService.UpdateCast(id, actorsId);
                return Ok(isSuccessful);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }

        [HttpPost("add-movie-categories/{Id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddMovieCategories(int Id, [FromBody] int[] categoriesId)
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
        public async Task<IActionResult> AddCast(int Id, [FromBody] Guid[] actorsId)
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
        public async Task<IActionResult> AddMovieCategory(int Id, [FromBody] Guid[] directorsId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var isAddSuccessful = await _movieService.AddMovieDirector(Id, directorsId);
            if (isAddSuccessful == false) return BadRequest();
            return Ok(isAddSuccessful);
        }

        [HttpGet("{id}/get-movie-director")]
        public async Task<IActionResult> GetMovieDirector(int id)
        {
           
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var movieDirectors = await _movieService.FindMovieDirectorByMovieId(id);
                return Ok(movieDirectors);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message); 
            }
            
        }

        [HttpGet("{id}/get-movie-category")]
        public async Task<IActionResult> GetMovieCategory(int id)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var movieCategorys = await _movieService.FindMovieCategoryByMovieId(id);
                return Ok(movieCategorys);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        } 
        
        [HttpGet("{id}/get-cast")]
        public async Task<IActionResult> GetCast(int id)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var cast = await _movieService.FindCastByMovieId(id);
                return Ok(cast);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
    }
}
