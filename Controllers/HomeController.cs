using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Scored.Models;
using Scored.ViewModels;
using Microsoft.Extensions.Configuration;

namespace Scored.Controllers
{

    public class HomeController : Controller
    {
        readonly IConfiguration _configuration;

        //readonly RetroRepository retroRepository = new RetroRepository();
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            IEnumerable<RetroViewModel> retroViewModels = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Startup.APIURL);
                var responseTask = client.GetAsync("retros");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<RetroViewModel>>();
                    readTask.Wait();

                    retroViewModels = readTask.Result;
                }
                else
                {
                    retroViewModels = Enumerable.Empty<RetroViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(retroViewModels);

        }
        [Route("[controller]/[action]")]
        public ActionResult About()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";


            //var APIURL = _configuration["API_URL"];
            ViewData["ApiUrl"] = _configuration["API_URL"];
            ViewData["AppUrl"] = _configuration["APP_URL"];
            ViewData["ASPNETCORE_URLS"] = _configuration["ASPNETCORE_URLS"];

            return View();
        }
        [Route("[controller]/[action]")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}
