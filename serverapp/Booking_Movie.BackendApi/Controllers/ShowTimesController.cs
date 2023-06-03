using Booking_Movie.Application.Catalog.ShowTimes;
using Booking_Movie.ViewModel.Catalog.ShowTimeVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimesController : ControllerBase
    {
        private readonly IShowTimeService _showTimeService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ShowTimesController(IShowTimeService showTimeService, IWebHostEnvironment webHostEnvironment)
        {
            _showTimeService = showTimeService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("paging/")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetShowTimePagingRequest pagingRequest)
        {
            try
            {
                var showTime = await _showTimeService.GetAllPaging(pagingRequest);
                if (showTime == null) return BadRequest("Cannot found showTime!");
                return Ok(showTime);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
