using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Application.Catalog.Auditoriums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditoriumsController : ControllerBase
    {
        private readonly IAuditoriumService _auditoriumService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AuditoriumsController(IAuditoriumService auditoriumService, IWebHostEnvironment webHostEnvironment)
        {
            _auditoriumService = auditoriumService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("{id}/seat-no")]
        public async Task<IActionResult> GetSeatByAuditorium(int id)
        {
            var seats = await _auditoriumService.GetSeatByAuditoriumId(id);
            if(seats != null)
            {
                return Ok(seats);
            }
            
            return BadRequest();    
        }
        
        [HttpGet("{id}/seat-row")]
        public async Task<IActionResult> GetRowOfSeatByAuditorium(int id)
        {
            var rows = await _auditoriumService.GetRowOfSeatsByAuditoriumId(id);
            if(rows != null)
            {
                return Ok(rows);
            }
            
            return BadRequest();    
        }
    }
}
