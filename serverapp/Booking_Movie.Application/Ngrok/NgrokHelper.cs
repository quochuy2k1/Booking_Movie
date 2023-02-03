using Booking_Movie.Utilities.Constants;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Ngrok
{
    public class NgrokHelper: INgrokHelper
    {
        public string? PublicUrl;
        public IConfiguration _configuration;
        public IHttpClientFactory _httpClientFactory;

        public NgrokHelper(IConfiguration configuration, IHttpClientFactory httpClientFactory) { 
            _configuration = configuration;
            _httpClientFactory = httpClientFactory; 
        }

        public async Task Init()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_configuration["NgrokTunnelBaseAddress"]!);
                var response = await client.GetAsync("api/tunnels");

                var responseString = await response.Content.ReadAsStringAsync();
                var responseJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(responseString);

                var tunnels = responseJson["tunnels"] as JArray;
                var tunnel = tunnels[0].ToObject<Dictionary<string, object>>();

                PublicUrl = tunnel["public_url"].ToString();
            }
            catch
            {
                PublicUrl = "";
            }
        }


        public async Task<string?> CreateEmbeddataWithPublicUrl(string url)
        {
            await Init();
            if (!string.IsNullOrEmpty(PublicUrl))
            {
               return PublicUrl + url;
            }
            return null;
        }

       
    }
}
