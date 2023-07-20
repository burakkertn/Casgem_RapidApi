using Casgem_RapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
namespace Casgem_RapidApi.Controllers
{
    public class CityLocationController : Controller
    {
        public async Task< IActionResult> Index(string cityname = "London")
        {

        
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityname}&locale=tr"),
                Headers =
    {
        { "X-RapidAPI-Key", "716f9ea423msh0c83514f7576543p197688jsndf55fedfe8c5" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
              var value = JsonConvert.DeserializeObject<List<LocationViewModel>>(body);
                return View(value);
            }
        }
    }
}
