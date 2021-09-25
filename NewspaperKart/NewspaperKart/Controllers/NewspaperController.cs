using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;
using NewspaperKart.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class NewspaperController : Controller
    {
        string Baseurl = "https://localhost:44387/";

        [HttpGet]
        public async Task<ActionResult> ViewNewspaper()
        {
            List<Newspapertbl> NewsInfo = new List<Newspapertbl>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Newspaper");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    NewsInfo = JsonConvert.DeserializeObject<List<Newspapertbl>>(SubsResponse);

                }
                return View(NewsInfo);
            }
        }

        [HttpGet]
        public ActionResult AddNewspaper()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddNewspaper(Newspapertbl n)
        {
            Newspapertbl Newsobj = new Newspapertbl();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(n), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44387/api/Newspaper", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Newsobj = JsonConvert.DeserializeObject<Newspapertbl>(apiResponse);
                }
            }
            return RedirectToAction("ViewNewspaper");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateNewspaper(int id)
        {
            Newspapertbl news = new Newspapertbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44387/api/Newspaper/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    news = JsonConvert.DeserializeObject<Newspapertbl>(apiResponse);
                }
            }
            return View(news);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateNewspaper(Newspapertbl n)
        {
            Newspapertbl receivedemp = new Newspapertbl();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = n.Id;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(n), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44387/api/Newspaper?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<Newspapertbl>(apiResponse);
                }
            }
            return RedirectToAction("ViewNewspaper");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteNewspaper(int id)
        {
            TempData["id"] = id;
            Newspapertbl n = new Newspapertbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44387/api/Newspaper/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    n = JsonConvert.DeserializeObject<Newspapertbl>(apiResponse);
                }
            }
            return View(n);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteNewspaper(Newspapertbl n)
        {
            int id = Convert.ToInt32(TempData["id"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44387/api/Newspaper?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewNewspaper");
        }








        //public static List<Newspaper> newspapers = new List<Newspaper>();

        ////public IActionResult Index()
        ////{
        ////    return View();
        ////}

        //public IActionResult NewspaperList()
        //{
        //    using (var db = new NewspaperkartContext())
        //    {
        //        newspapers = db.Newspapers.ToList();
        //    }
        //    return View(newspapers);
        //}

        //public IActionResult AddNewspaper()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult AddNewspaper(Newspaper e)
        //{
        //    using (var db = new NewspaperkartContext())
        //    {
        //        db.Newspapers.Add(e);
        //        db.SaveChanges();
        //    }
        //    return RedirectToAction("NewspaperList");
        //}

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    Newspaper e = new Newspaper();
        //    using (var db = new NewspaperkartContext())
        //    {
        //        e = db.Newspapers.Find(id);
        //    }
        //    return View(e);
        //}

        //[HttpPost]
        //public IActionResult Edit(Newspaper e)
        //{
        //    using (var db = new NewspaperkartContext())
        //    {
        //        db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //        db.SaveChanges();

        //    }
        //    return RedirectToAction("NewspaperList");
        //}


        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    Newspaper e = new Newspaper();
        //    using (var db = new NewspaperkartContext())
        //    {
        //        e = db.Newspapers.Find(id);
        //        //db.Subscriptions.Remove(e);
        //        //db.SaveChanges();
        //    }
        //    return View(e);
        //}


        //[HttpPost]
        //public IActionResult Delete(Newspaper e)
        //{
        //    using (var db = new NewspaperkartContext())
        //    {
        //        db.Newspapers.Remove(e);
        //        db.SaveChanges();
        //    }

        //    return RedirectToAction("SubscriptionList");
        //}
    }
}
