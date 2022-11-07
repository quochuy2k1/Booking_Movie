using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ActorsController : ControllerBase
    {
        private readonly IActorService _actorService;
        private readonly IWebHostEnvironment webHostEnvironment;


        public ActorsController(IActorService actorService, IWebHostEnvironment webHostEnvironment)
        {
            _actorService = actorService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get()
        {
            var actors = await _actorService.GetAll();
            return Ok(actors);
        }
        
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetById(Guid id)
        {
            var host = $"{Request.Scheme}://{Request.Host}";
            var actor = await _actorService.GetById(id, host);
            if (actor == null) return BadRequest("Cannot found actor!");
            await _actorService.UpdateViewCount(id);
            return Ok(actor);
        }


        [HttpGet("paging/")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetActorPagingRequest pagingRequest)
        {
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var actor = await _actorService.GetAllPaging(pagingRequest, host);
                if (actor == null) return BadRequest("Cannot found actors!");
                return Ok(actor);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create")]
        [Authorize(Roles = "Admin")]       
        
        public async Task<IActionResult> Create([FromForm]ActorCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var host = $"{Request.Scheme}://{Request.Host}";
            var ActorId = await _actorService.Create(request);
            if (ActorId == Guid.Empty) return BadRequest();

            var actor_created = await _actorService.GetById(ActorId, host);
            return Ok(actor_created);
        } 

        [HttpPut("update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id, [FromForm]ActorUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var isSuccess = await _actorService.Update(id, request);
            if (!isSuccess) return BadRequest();
            return Ok(isSuccess);
        }
        [HttpDelete("del/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromForm]Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var isSuccess = await _actorService.Delete(id);
            if (!isSuccess) return BadRequest();
            return Ok(isSuccess);
        }

        [HttpGet("Images/GetImage")]
        [AllowAnonymous]
        public IActionResult GetImge()
        {
            //var file = Path.Combine(webHostEnvironment.WebRootPath, "actor-content/1db66d86-6211-4ab2-85bb-e22974196c09.jpg");
            //return Ok(new { image = File(System.IO.File.ReadAllBytes(file), "image/jpge") });

            var host = $"{Request.Scheme}://{Request.Host}/";
            return Ok(host);
        }
    }
}
