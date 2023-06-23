using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Application.Catalog.Auditoriums;
using Booking_Movie.Utilities.Constants;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.SeatNoVM;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditoriumsController : ControllerBase
    {
        private readonly IAuditoriumService _auditoriumService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AuditoriumsController(IAuditoriumService auditoriumService, IWebHostEnvironment webHostEnvironment)
        {
            _auditoriumService = auditoriumService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("{id}/seat-no")]
        public async Task<IActionResult> GetSeatByAuditorium(int id)
        {
            var seats = await _auditoriumService.GetSeatByAuditoriumId(id);
            if (seats != null)
            {
                return Ok(seats);
            }

            return BadRequest();
        }

        [HttpGet("{id}/seat-row")]
        public async Task<IActionResult> GetRowOfSeatByAuditorium(int id)
        {
            var rows = await _auditoriumService.GetRowOfSeatsByAuditoriumId(id);
            if (rows != null)
            {
                return Ok(rows);
            }

            return BadRequest();
        }

        [HttpGet("paging/")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetAuditoriumPagingRequest pagingRequest)
        {
            try
            {
                var host = $"{Request.Scheme}://{Request.Host}";
                var auditoriums = await _auditoriumService.GetAllPaging(pagingRequest, host);
                if (auditoriums == null) return BadRequest("Cannot found auditoriums!");
                return Ok(auditoriums);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("paging/admin")]
        public async Task<IActionResult> GetAllPagingAdmin([FromForm] GetAuditoriumPagingAdminRequest request)
        {
            var host = $"{Request.Scheme}://{Request.Host}";
            var sort = Request.Form["sort"];
            var filter = Request.Form["filter"];
            var group = Request.Form["group"];

            if (!String.IsNullOrEmpty(filter))
            {
                request.Filter = JsonConvert.DeserializeObject<IList>(filter);
            }

            if (!String.IsNullOrEmpty(sort))
            {
                request.Sort = JsonConvert.DeserializeObject<SortingInfo[]>(sort);
            }
            if (!String.IsNullOrEmpty(group))
            {
                request.Group = JsonConvert.DeserializeObject<GroupingInfo[]>(group);
            }
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var auditoriums = await _auditoriumService.GetAuditoriumPagingAdmin(request, host);
            return Ok(auditoriums);
        }

        [HttpPost("{auditoriumId}/save-changes")]
        public async Task<IActionResult> SeatNoSaveChange(int auditoriumId, [FromBody] SeatNoSaveChangeRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _auditoriumService.SeatNoSaveChange(auditoriumId, request);
            if(result == false) return BadRequest(new { Status = StatusResponseConstant.FAILED, Message = StatusMessageResponseConstant.SAVE_FAILD });
            return Ok(new { Status = StatusResponseConstant.SUCCESS, Message = StatusMessageResponseConstant.SAVE_SUCCESS });
        }
    }
}
