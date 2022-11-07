using Booking_Movie.Application.Catalog.Producers;
using Booking_Movie.ViewModel.Catalog.ProducerVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducersController : ControllerBase
    {
        private readonly IProducerService _producerService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProducersController(IProducerService producerService, IWebHostEnvironment webHostEnvironment)
        {
            _producerService = producerService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var producers = await _producerService.GetAll();
            return Ok(producers);
        }

        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid id)
        {
            var producer = await _producerService.GetById(id);
            if (producer == null) return BadRequest("Cannot found producer!");
            return Ok(producer);
        }

        [HttpGet("paging/")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetMovieCategoryPagingRequest pagingRequest)
        {
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var producer = await _producerService.GetAllPaging(pagingRequest, host);
                if (producer == null) return BadRequest("Cannot found producers!");
                return Ok(producer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromForm] ProducerCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var ProducerId = await _producerService.Create(request);
            if (ProducerId == Guid.Empty) return BadRequest();

            var producer_created = await _producerService.GetById(ProducerId);
            return Ok(producer_created);
        }

        [HttpPut("update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id, [FromForm] ProducerUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var isSuccess = await _producerService.Update(id, request);
            if (!isSuccess) return BadRequest();
            return Ok(isSuccess);
        }
        [HttpDelete("delete/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var isSuccess = await _producerService.Delete(id);
            if (!isSuccess) return BadRequest();
            return Ok(isSuccess);
        }

        [HttpGet("Images/GetImage")]
        [AllowAnonymous]
        public IActionResult GetImge()
        {
            //var file = Path.Combine(webHostEnvironment.WebRootPath, "producer-content/1db66d86-6211-4ab2-85bb-e22974196c09.jpg");
            //return Ok(new { image = File(System.IO.File.ReadAllBytes(file), "image/jpge") });

            var host = $"{Request.Scheme}://{Request.Host}/";
            return Ok(host);
        }
    }
}