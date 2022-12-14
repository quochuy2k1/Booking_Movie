using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Data.Entities;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

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
            var host = $"{Request.Scheme}://{Request.Host}";
            var actors = await _actorService.GetAll(host);
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
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var ActorId = await _actorService.Create(request);
                if (ActorId == Guid.Empty) return BadRequest("Xãy ra lỗi khi tạo diễn viên.Vui lòng tạo lại");

                var actor_created = await _actorService.GetById(ActorId, host);
                return Ok(actor_created);

            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        } 

        [HttpPut("update/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id, [FromForm]ActorUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var actorId = await _actorService.Update(id, request);
                if (actorId == Guid.Empty) return BadRequest("Xãy ra lỗi khi cập nhật diễn viên.Vui lòng làm lại");
                var actorUpdated = await _actorService.GetById(actorId, host);
                return Ok(actorUpdated);

            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("del")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete([FromBody]Guid[] id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var actorsId = await _actorService.Delete(id);
                if (actorsId == null) return BadRequest("Không thể xoá vì một số lý do.Vui lòng thử lại.");
                return Ok(actorsId);
            }
            catch (DbUpdateException)
            {

                return StatusCode(500, "Không thể xoá nếu bảng movie còn tham chiếu đến bảng khác. (Danh mục phim, Đạo diễn, Diễn viên). Phải xoá những tham chiếu đến bảng này hết trước khi xoá.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        [HttpGet("{id}/get-actor-image-detail/{amId}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetActorImageDetail(Guid id, int amId)
        {
            var host = $"{Request.Scheme}://{Request.Host}";
            var actors = await _actorService.GetActorImageDetail(amId, id, host);
            return Ok(actors);
        }

        [HttpPost("{id}/create-actor-image")]
        [Authorize(Roles = "Admin")]

        public async Task<IActionResult> CreateActorImage(Guid id, [FromForm] ActorImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var ActorImageId = await _actorService.CreateActorImage(id, request);
                if (ActorImageId == null) return BadRequest("Xãy ra lỗi khi tạo mới hình diễn viên.Vui lòng tạo lại");

                var actor_image_created = await _actorService.GetActorImageDetail(ActorImageId.Value, id, host);
                return Ok(actor_image_created);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPut("{id}/update-actor-image/{amid}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(Guid id, int amid, [FromForm] ActorImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var actorImageId = await _actorService.UpdateActorImage(amid, id,  request);
                if (actorImageId == null) return BadRequest("Xãy ra lỗi khi cập nhật hình diễn viên.Vui lòng làm lại");
                var actorMovieUpdated = await _actorService.GetActorImageDetail(actorImageId.Value, id, host);
                return Ok(actorMovieUpdated);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}/get-all-actor-image")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllActorImage(Guid id)
        {
            var host = $"{Request.Scheme}://{Request.Host}";
            var actors = await _actorService.GetAllActorImage(id, host);
            return Ok(actors);
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
