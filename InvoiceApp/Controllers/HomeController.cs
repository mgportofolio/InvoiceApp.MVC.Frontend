using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InvoiceApp.Models;
using InvoiceApp.Models.DropdownModel;
using InvoiceApp.Models.Wrapper;
using System.Net.Http;
using InvoiceApp.Helper;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using InvoiceApp.Models.Response;

namespace InvoiceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppSettings _SettingMan;

        public HomeController(ILogger<HomeController> logger, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            this._SettingMan = appSettings.Value;
        }

        public async Task<IActionResult> Index()
        {
            var model = new InitialWrapper();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(this._SettingMan.BaseUriApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/v1/initial");

                if (Res.IsSuccessStatusCode)
                {
                    var Response = Res.Content.ReadAsStringAsync().Result;

                    var resObj = JsonConvert.DeserializeObject<InitialResponse>(Response);
                    model.Response = resObj;
                }
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Index(string a)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
