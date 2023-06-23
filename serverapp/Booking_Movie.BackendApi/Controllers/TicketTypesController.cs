using Booking_Movie.Application.Catalog.Tickets;
using Booking_Movie.Application.Catalog.TicketTypes;
using Booking_Movie.ViewModel.Catalog.TicketTypeVM;
using Booking_Movie.ViewModel.Catalog.TicketVM;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketTypesController : ControllerBase
    {
        private readonly ITicketTypeService _ticketTypeService;

        public TicketTypesController(ITicketTypeService ticketTypeService)
        {
            _ticketTypeService = ticketTypeService;
        }

        [HttpPost("paging/admin")]
        public async Task<IActionResult> GetAllTicketPagingAdmin([FromForm] GetTicketTypePagingAdminRequest request)
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
            var tickets = await _ticketTypeService.GetTicketTypePagingAdmin(request);

            return Ok(tickets);
        }
    }
}
