using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Scored.Models;
using Scored.ViewModels;

namespace Scored.Controllers
{
    public class SkillController : Controller
    {
        //public SkillController()
        //{

        //}
        //private readonly ISkillRepository _skillRepository = new SkillRepository();
        public ActionResult Index()
        {
            IEnumerable<SkillViewModel> skills = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Startup.APIURL);
                var responseTask = client.GetAsync("skills");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<SkillViewModel>>();
                    readTask.Wait();

                    skills = readTask.Result;
                }
                else
                {
                    skills = Enumerable.Empty<SkillViewModel>();
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(skills);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SkillViewModel skillViewModel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Startup.APIURL+ "skills");
                //HTTP POST
                var postTask = client.PostAsJsonAsync<SkillViewModel>("skills", skillViewModel);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(skillViewModel);
        }

        public ActionResult Edit(int? id)
        {
            SkillViewModel model = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Startup.APIURL);
                //HTTP GET
                var responseTask = client.GetAsync("skills/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<SkillViewModel>();
                    readTask.Wait();

                    model = readTask.Result;
                }
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(SkillViewModel skillViewModel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Startup.APIURL + "skills");
                //HTTP POST
                var putTask = client.PutAsJsonAsync<SkillViewModel>("skills", skillViewModel);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(skillViewModel);
        }
    }
}