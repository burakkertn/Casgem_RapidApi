//using Microsoft.AspNetCore.Mvc;

//namespace Casgem_RapidApi.Controllers
//{
//    public class BookingController : Controller
//    {
//        [HttpGet]
//        public IActionResult Index()
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Index(string x)
//        {
//            using System.Net.Http.Headers;
//            var client = new HttpClient();
//            var request = new HttpRequestMessage
//            {
//                Method = HttpMethod.Get,
//                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-09-27&filter_by_currency=AED&dest_id=-553173&locale=en-gb&checkout_date=2023-09-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
//                Headers =
//    {
//        { "X-RapidAPI-Key", "716f9ea423msh0c83514f7576543p197688jsndf55fedfe8c5" },
//        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
//    },
//            };
//            using (var response = await client.SendAsync(request))
//            {
//                response.EnsureSuccessStatusCode();
//                var body = await response.Content.ReadAsStringAsync();
//                Console.WriteLine(body);
//            }
//            return View();
//        }
//    }
//}
