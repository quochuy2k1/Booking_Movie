using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Application.Catalog.Combos;
using Booking_Movie.Utilities.Constants;
using Booking_Movie.ViewModel.Catalog.ComboVM;
using Booking_Movie.ViewModel.Catalog.TicketVM;
using DevExtreme.AspNet.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CombosController : ControllerBase
    {
        private readonly IComboService _comboService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CombosController(IComboService comboService, IWebHostEnvironment webHostEnvironment)
        {
            _comboService = comboService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> GetCombos()
        {
            var combos = await _comboService.GetCombos();
            try
            {
                if (combos != null)
                {
                    return Ok(combos);
                }
                return BadRequest();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        [HttpPost("paging/admin")]
        public async Task<IActionResult> GetAllComboPagingAdmin([FromForm] GetComboPagingAdminRequest request)
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
            var combos = await _comboService.GetTicketPagingAdmin(request);

            return Ok(combos);
        }

        [HttpPost("create")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromForm] DXComboCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var host = $"{Request.Scheme}://{Request.Host}";
            var req = Request.Form["values"];
            var requestParse = JsonConvert.DeserializeObject<ComboCreateRequest>(req);
            var combo = await _comboService.Create(requestParse);
            if (combo == null) return BadRequest(new { Status = StatusResponseConstant.FAILED, Message = StatusMessageResponseConstant.ADD_FAILD });

            return Ok(new { Status = StatusResponseConstant.SUCCESS, Message = StatusMessageResponseConstant.ADD_SUCCESS });
        }

        [HttpPut("update")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update([FromForm] DXComboUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var host = $"{Request.Scheme}://{Request.Host}";
            var req = Request.Form["values"];
            var requestParse = JsonConvert.DeserializeObject<ComboUpdateRequest>(req);
            var combo = await _comboService.Update(request.Key!.Value, requestParse);
            if (combo == null) return BadRequest(new { Status = StatusResponseConstant.FAILED, Message = StatusMessageResponseConstant.UPDATE_FAILD });

            return Ok(new { Status = StatusResponseConstant.SUCCESS, Message = StatusMessageResponseConstant.UPDATE_SUCCESS });
        }
    }
}
