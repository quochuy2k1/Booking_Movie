using Booking_Movie.Application.Catalog.Tickets;
using Booking_Movie.Utilities.Constants;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Booking_Movie.ViewModel.Catalog.TicketVM;
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
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public TicketsController(ITicketService ticketService, IWebHostEnvironment webHostEnvironment)
        {
            _ticketService = ticketService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> GetTickets()
        {
            try
            {
                var tickets = await _ticketService.GetTickets();
                return Ok(tickets);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 
        
        [HttpGet("{screeningId}/screening")]
        public async Task<IActionResult> GetTicketByScreeningId(string screeningId)
        {
            try
            {
                var tickets = await _ticketService.GetTicketByScreeningId(screeningId);
                return Ok(tickets);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 
        
        [HttpGet("movie/{movieId}")]
        public async Task<IActionResult> GetTicketByMovieId(string movieId, [FromQuery] DateTime dateTo)
        {
            try
            {
                var tickets = await _ticketService.GetTicketByMovieId(movieId, dateTo);
                return Ok(tickets);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost("paging/admin")]
        public async Task<IActionResult> GetAllTicketPagingAdmin([FromForm] GetTicketPagingAdminRequest request)
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
            request.PrimaryKey = new string[] { "Id" };
            request.SortByPrimaryKey = false;
            var tickets = await _ticketService.GetTicketPagingAdmin(request);

            return Ok(tickets);
        }

        [HttpPost("create")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromForm] DXTicketCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var host = $"{Request.Scheme}://{Request.Host}";
            var req = Request.Form["values"];
            var requestParse = JsonConvert.DeserializeObject<TicketCreateRequest>(req);
            var ticket = await _ticketService.Create(requestParse);
            if (ticket == null) return BadRequest(new { Status = StatusResponseConstant.FAILED, Message = StatusMessageResponseConstant.ADD_FAILD });

            return Ok(new { Status = StatusResponseConstant.SUCCESS, Message = StatusMessageResponseConstant.ADD_SUCCESS });
        }
        
        [HttpPut("update")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromForm] DXTicketUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var host = $"{Request.Scheme}://{Request.Host}";
            var req = Request.Form["values"];
            var requestParse = JsonConvert.DeserializeObject<TicketUpdateRequest>(req);
            var ticket = await _ticketService.Update(request.Key!.Value, requestParse);
            if (ticket == null) return BadRequest(new { Status = StatusResponseConstant.FAILED, Message = StatusMessageResponseConstant.UPDATE_FAILD });

            return Ok(new { Status = StatusResponseConstant.SUCCESS, Message = StatusMessageResponseConstant.UPDATE_SUCCESS });
        }

        #region Report



        #endregion

    }
}
