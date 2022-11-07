using Booking_Movie.Application.Catalog.Directors;
using Booking_Movie.ViewModel.Catalog.DirectorVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorService _directorService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public DirectorsController(IDirectorService directorService, IWebHostEnvironment webHostEnvironment)
        {
            _directorService = directorService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var directors = await _directorService.GetAll();
            return Ok(directors);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid id)
        {
            var director = await _directorService.GetById(id);
            if (director == null) return BadRequest("Cannot found director!");
            await _directorService.UpdateViewCount(id);
            return Ok(director);
        }

        [HttpGet("paging/")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetDirectorPagingRequest pagingRequest)
        {
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var director = await _directorService.GetAllPaging(pagingRequest, host);
                if (director == null) return BadRequest("Cannot found directors!");
                return Ok(director);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromForm] DirectorCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var ActorId = await _directorService.Create(request);
            if (ActorId == Guid.Empty) return BadRequest();

            var director_created = await _directorService.GetById(ActorId);
            return Ok(director_created);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id,[FromForm] DirectorUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var isSuccess = await _directorService.Update(id, request);
            if (!isSuccess) return BadRequest();
            return Ok(isSuccess);
        }
        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromForm] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var isSuccess = await _directorService.Delete(id);
            if (!isSuccess) return BadRequest();
            return Ok(isSuccess);
        }

        [HttpGet("Images/GetImage")]
        [AllowAnonymous]
        public IActionResult GetImge()
        {
            //var file = Path.Combine(webHostEnvironment.WebRootPath, "director-content/1db66d86-6211-4ab2-85bb-e22974196c09.jpg");
            //return Ok(new { image = File(System.IO.File.ReadAllBytes(file), "image/jpge") });

            var host = $"{Request.Scheme}://{Request.Host}/";
            return Ok(host);
        }
    }
}