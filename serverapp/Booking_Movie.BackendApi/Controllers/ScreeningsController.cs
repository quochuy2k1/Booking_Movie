using Booking_Movie.Application.Catalog.Screenings;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Constants;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        [HttpPost("add-new")]
        public async Task<IActionResult> AddNew([FromForm] ScreeningCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var req = Request.Form["values"];  
                request = JsonConvert.DeserializeObject<ScreeningCreateRequest>(req);
                var screening = await _screeningService.AddNew(request);
                if (screening == null || screening == false) return BadRequest("Xãy ra lỗi khi tạo lịch chiếu phim.Vui lòng tạo lại");

                //var screening_created = await _screeningService.GetById(screening.Id);
                return Ok(new {Status = StatusResponseContant.SUCCESS, Message = StatusMessageResponseContant .ADD_SUCCESS});

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
        
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromForm] ScreeningUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var req = Request.Form["values"];  
                var key = Request.Form["key"];  
                request = JsonConvert.DeserializeObject<ScreeningUpdateRequest>(req);
                var screening = await _screeningService.Update(Convert.ToInt32(key), request);
                if (screening == null || screening == false) return BadRequest("Xãy ra lỗi khi cập nhật lịch chiếu phim.Vui lòng cập nhập lại");

                //var screening_created = await _screeningService.GetById(screening.Id);
                return Ok(new {Status = StatusResponseContant.SUCCESS, Message = StatusMessageResponseContant.UPDATE_SUCCESS});

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
