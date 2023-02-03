
using Booking_Movie.Application.Catalog.ScreeningTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreeningTypesController : ControllerBase
    {
        private readonly IScreeningTypeService _screeningTypeService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ScreeningTypesController(IScreeningTypeService screeningTypeService, IWebHostEnvironment webHostEnvironment)
        {
            _screeningTypeService = screeningTypeService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllScreeningType()
        {
            try
            {
         
                var screeningTypes = await _screeningTypeService.GetAllScreeningType();
                if (screeningTypes == null) return BadRequest("Cannot found screening types!");
                return Ok(screeningTypes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
