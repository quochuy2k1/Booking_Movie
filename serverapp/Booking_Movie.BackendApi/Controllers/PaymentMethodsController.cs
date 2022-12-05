
using Booking_Movie.Application.Catalog.PaymentMethods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IPaymentMethodService _paymentMethodService;
        private readonly IWebHostEnvironment webHostEnvironment;

        public PaymentMethodsController(IPaymentMethodService paymentMethodService, IWebHostEnvironment webHostEnvironment)
        {
            _paymentMethodService = paymentMethodService;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("get-payment-methods")]
        public async Task<IActionResult> GetAll()
        {
            var paymentMethods = await _paymentMethodService.GetAll();
            if (paymentMethods == null) return  BadRequest();

            return Ok(paymentMethods);
        }
    }
}
