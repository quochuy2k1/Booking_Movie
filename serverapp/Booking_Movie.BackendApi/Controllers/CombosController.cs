using Booking_Movie.Application.Catalog.Actors;
using Booking_Movie.Application.Catalog.Combos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
