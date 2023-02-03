using Booking_Movie.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Booking_Movie.Payment.Momo
{
    public class PaymentRequest: IPaymentRequest
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PaymentRequest(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> sendPaymentRequest(string endpoint, string postJsonString)
        {

            try
            {
                var sessions = _httpContextAccessor
               .HttpContext
               .Session
               .GetString(SystemConstant.AppSettings.Token);

                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_configuration[SystemConstant.AppSettings.BaseAddress]!);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);
                
                var postData = postJsonString;

                var data = Encoding.UTF8.GetBytes(postData);

                var requestContent = new StringContent(postJsonString, Encoding.UTF8, Application.Json);

                var response = await client.PostAsync(endpoint, requestContent);

                string jsonresponse = await response.Content.ReadAsStringAsync();
            
                //todo parse it
                return jsonresponse;
                //return new MomoResponse(mtid, jsonresponse);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
