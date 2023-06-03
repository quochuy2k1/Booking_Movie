using Booking_Movie.Application.Catalog.Cinemas;
using Booking_Movie.ViewModel.Catalog.CinemaVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly ICinemasService _cinemasService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CinemasController(ICinemasService cinemasService, IWebHostEnvironment webHostEnvironment)
        {
            _cinemasService = cinemasService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllCinema()
        {
            try
            {
               
                var cinemas = await _cinemasService.GetAllCinema();
                if (cinemas == null) return BadRequest("Cannot found cinemas!");
                return Ok(cinemas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("{id}/get-auditorium")]
        public async Task<IActionResult> GetAuditoriumByCinemaId(int id)
        {
            try
            {
               
                var cinemas = await _cinemasService.GetAuditoriumByCinemaId(id);
                if (cinemas == null) return BadRequest("Cannot found auditorium by cinema id!" + id);
                return Ok(cinemas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("paging/")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetCinemaPagingRequest pagingRequest)
        {
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var cinemas = await _cinemasService.GetAllPaging(pagingRequest, host);
                if (cinemas == null) return BadRequest("Cannot found cinemas!");
                return Ok(cinemas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 
        
        [HttpPost("paging/admin")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllAdminPaging([FromForm] GetCinemaPagingAdminRequest pagingRequest)
        {
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var cinemas = await _cinemasService.GetAllPagingAdmin(pagingRequest, host);
                if (cinemas == null) return BadRequest("Cannot found cinemas!");
                return Ok(cinemas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
