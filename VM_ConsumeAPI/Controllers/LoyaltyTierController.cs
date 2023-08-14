using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using VM_ConsumeAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VM_ConsumeAPI.Controllers
{
    public class LoyaltyTierController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:7264/api");
        private readonly HttpClient _httpClient;

        public  LoyaltyTierController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress= baseAddress;

        }
        [HttpGet]
        public IActionResult Index()
        {
            List<LoyaltyViewModel> LoyaltyList = new List<LoyaltyViewModel>();
            HttpResponseMessage response = _httpClient.GetAsync(baseAddress + "/loyaltytiers").Result;


            if(response.IsSuccessStatusCode) { 

                string data=response.Content.ReadAsStringAsync().Result;
             //  LoyaltyList=JsonConvert.DeserializeObject<List<LoyaltyViewModel>>(data);
               
            
            }
            return View(data);
        }
    }
}
