using HotelProject.WebUI.Dtos.Guest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class AdminGuestController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AdminGuestController(IHttpClientFactory httpClintFactory)
		{
			_httpClientFactory = httpClintFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:1650/api/Guest");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultGuestDto>>(jsonData);
				return View(values);
			}
			return View();
		}
		[HttpGet]
		public IActionResult AddGuest()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> AddGuest(CreateGuestDto model)
		{
			if (ModelState.IsValid)
			{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("http://localhost:1650/api/Guest", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
			}
            else
            {
			return View();
            }
        }
		public async Task<IActionResult> DeleteGuest(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"http://localhost:1650/api/Guest/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateGuest(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:1650/api/Guest/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateGuestDto>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateGuest(UpdateGuestDto model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("http://localhost:1650/api/Guest/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}