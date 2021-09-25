using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewspaperKart.Models;
using Newtonsoft.Json;

namespace NewspaperKart.Controllers
{
    public class SubscriptionController : Controller
    {
        string Baseurl = "https://localhost:44337/";

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            List<Subscriptiontbl> SubsInfo = new List<Subscriptiontbl>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Subscription");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    SubsInfo = JsonConvert.DeserializeObject<List<Subscriptiontbl>>(SubsResponse);

                }
                return View(SubsInfo);
            }
        }

        [HttpGet]
        public ActionResult AddSubscription()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddSubscription(Subscriptiontbl s)
        {
            Subscriptiontbl Subsobj = new Subscriptiontbl();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(s), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44337/api/Subscription", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Subsobj = JsonConvert.DeserializeObject<Subscriptiontbl>(apiResponse);
                }
            }
            return RedirectToAction("Index", "Payment");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateSubscription(int id)
        {
            Subscriptiontbl subs = new Subscriptiontbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44337/api/Subscription/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    subs = JsonConvert.DeserializeObject<Subscriptiontbl>(apiResponse);
                }
            }
            return View(subs);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateSubscription(Subscriptiontbl s)
        {
            Subscriptiontbl receivedemp = new Subscriptiontbl();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = s.SubId;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(s), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44337/api/Subscription?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<Subscriptiontbl>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteSubscription(int id)
        {
            TempData["subid"] = id;
            Subscriptiontbl s = new Subscriptiontbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44337/api/Subscription/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    s = JsonConvert.DeserializeObject<Subscriptiontbl>(apiResponse);
                }
            }
            return View(s);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteSubscription(Subscriptiontbl s)
        {
            int subid = Convert.ToInt32(TempData["subid"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44337/api/Subscription?id=" + subid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
