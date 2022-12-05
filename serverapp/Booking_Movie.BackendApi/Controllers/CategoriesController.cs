using Booking_Movie.Application.Catalog.Categories;
using Booking_Movie.ViewModel.Catalog.CategoryVM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICateroryService _cateroryService;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CategoriesController(ICateroryService cateroryService, IWebHostEnvironment webHostEnvironment)
        {
            _cateroryService = cateroryService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _cateroryService.GetAll();
            if(categories == null) return BadRequest();

            return Ok(categories);
        }

        [HttpGet("create")]
        public async Task<IActionResult> Create(CategoryCreateRequest request)
        {
            var categoryId = await _cateroryService.Create(request);
            if (categoryId == null) return BadRequest();

            return Ok(categoryId);
        }
    }
}
