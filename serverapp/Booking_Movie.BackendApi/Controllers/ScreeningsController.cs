using Booking_Movie.Application.Catalog.Screenings;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreeningsController : ControllerBase
    {
        private readonly IScreeningService _screeningService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ScreeningsController(IScreeningService screeningService, IWebHostEnvironment webHostEnvironment)
        {
            _screeningService = screeningService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> AddNew([FromBody]ScreeningCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                
                var screening = await _screeningService.AddNew(request);
                if (screening == null) return BadRequest("Xãy ra lỗi khi tạo diễn viên.Vui lòng tạo lại");

                var screening_created = await _screeningService.GetById(screening.Id);
                return Ok(screening_created);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
