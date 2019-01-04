using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Scored.Models;
using Scored.ViewModels;
using Microsoft.AspNetCore.Http;

namespace Scored.Controllers
{
    public class RetroController : Controller
    {
        [HttpGet]
        public ActionResult Evaluate()
        {
            try
            {
                var skillsList = GetSkillsList();

                if (skillsList != null)
                {
                    ViewBag.skillsList = skillsList;
                }
                var LevelsList = Enum.GetValues(typeof(Level))
                                .Cast<Level>()
                                .ToList();
                if (LevelsList != null)
                {
                    ViewBag.LevelsList = LevelsList;
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                e.Message.ToString();
            }

            return View();
        }

        [HttpPost]
        public ActionResult Evaluate(IFormCollection formCollection, RetroViewModel retroViewModel)
        {
            foreach (var key in formCollection.AsParallel())
            {

                string retroDate = formCollection["RetroDate"];
                var skillIDs = formCollection["SkillID"].ToList();
                var levels = formCollection["Level"].ToList();

                for (int i = 0; i < skillIDs.Count(); i++)
                {
                    Console.WriteLine(i);
                    int skillID = ConvertToInt(skillIDs[i]);
                    Level levelID = ConvertToLevel(levels[i]);
                    var retro = new Retro()
                    {
                        RetroDate = Convert.ToDateTime(retroDate),
                        Level = (Level)levelID,
                        SkillID = skillID
                    };

                    PostARetroItem(retro);

                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return RedirectToAction("Report");
            }
            return View(retroViewModel);
        }

        private int ConvertToInt(string str)
        {
            int i = 0;
            return string.IsNullOrEmpty(str) ? i : Int32.Parse(str);

        }

        private Level ConvertToLevel(string str)
        {
            Level l = Level.None;
            return (Scored.Models.Level)(string.IsNullOrEmpty(str) ? l : Enum.Parse(typeof(Level), str));

        }
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                IEnumerable<RetroViewModel> retroViewModels = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Startup.APIURL + "/retros");
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
            catch (Exception e)
            {
                e.Message.ToString();
                return View();
            }
        }
        [HttpGet]
        public ActionResult Report()
        {
            try
            {
                IEnumerable<RetroViewModel> retroViewModels = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Startup.APIURL + "retros");
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
            catch (Exception e)
            {
                e.Message.ToString();
                return View();
            }
        }
        [HttpGet]
        public ActionResult Evaluate1()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Evaluate1(RetroViewModel retroViewModel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Startup.APIURL);
                var postTask = client.PostAsJsonAsync<RetroViewModel>("retros", retroViewModel);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Report");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(retroViewModel);
        }

        private IList<SkillViewModel> GetSkillViewModelList()
        {
            IList<SkillViewModel> data = null;
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Startup.APIURL + "skills");
                //HTTP GET
                var responseTask = client.GetAsync("skills");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<SkillViewModel>>();
                    readTask.Wait();
                    data = readTask.Result;
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return data;
        }


        private bool PostARetroItem(Retro retro)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Startup.APIURL + "retros");
                //HTTP POST
                var postTask = client.PostAsJsonAsync<Retro>("retros", retro);
                postTask.Wait();

                var result = postTask.Result;
                return result.IsSuccessStatusCode ? true : false;
            }

        }

        private IEnumerable<SkillListModel> GetSkillsList()
        {
            IList<SkillListModel> data = null;
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Startup.APIURL + "listskills");
                //HTTP GET
                var responseTask = client.GetAsync("listskills");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<SkillListModel>>();
                    readTask.Wait();
                    data = readTask.Result;
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
                return data;
            }

        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            RetroViewModel model = null;

            try
            {

                IEnumerable<SkillListModel> skillsList = null;
                skillsList = GetSkillsList();

                if (skillsList != null)
                {
                    ViewBag.skillsList = skillsList;
                }


                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Startup.APIURL + "retros"); 
                    //HTTP GET
                    var retroResposeTask = client.GetAsync("retros?id=" + id.ToString());
                    retroResposeTask.Wait();

                    var retroResult = retroResposeTask.Result;
                    if (retroResult.IsSuccessStatusCode)
                    {
                        var readRetroData = retroResult.Content.ReadAsAsync<RetroViewModel>();
                        readRetroData.Wait();

                        model.Skills = skillsList;
                        model = readRetroData.Result;

                    }
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");

                e.Message.ToString();
            }


            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RetroViewModel retroViewModel)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Startup.APIURL + "retros");
                //HTTP POST
                var putTask = client.PutAsJsonAsync<RetroViewModel>("retros", retroViewModel);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Report");
                }
            }
            return View(retroViewModel);

        }

    }
}