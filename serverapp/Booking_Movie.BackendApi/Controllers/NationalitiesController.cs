using Booking_Movie.Application.Catalog.Nationalities;
using Booking_Movie.ViewModel.Catalog.CategoryVM;
using Booking_Movie.ViewModel.Catalog.NationalityVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalitiesController : ControllerBase
    {
        private readonly INationalityService _nationalityService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public NationalitiesController(INationalityService nationalityService, IWebHostEnvironment webHostEnvironment)
        {
            _nationalityService = nationalityService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var nationalities = await _nationalityService.GetAll();
            if (nationalities == null) return BadRequest();

            return Ok(nationalities);
        }

        [HttpGet("create")]
        public async Task<IActionResult> Create(NationalityCreateRequest request)
        {
            var nationalityId = await _nationalityService.Create(request);
            if (nationalityId == null) return BadRequest();

            return Ok(nationalityId);
        }
    }
}
