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
    public class FeedbackController : Controller
    {
        string Baseurl = "https://localhost:44353/";

        [HttpGet]
        public async Task<ActionResult> ViewFeedback()
        {
            List<Feedbacktbl> FeedbckInfo = new List<Feedbacktbl>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Feedbacktbl");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    FeedbckInfo = JsonConvert.DeserializeObject<List<Feedbacktbl>>(SubsResponse);

                }
                return View(FeedbckInfo);
            }
        }

        [HttpGet]
        public ActionResult AddFeedback()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddFeedback(Feedbacktbl f)
        {
            Feedbacktbl Feedbckobj = new Feedbacktbl();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(f), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44353/api/Feedbacktbl", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Feedbckobj = JsonConvert.DeserializeObject<Feedbacktbl>(apiResponse);
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateFeedback(int id)
        {
            Feedbacktbl fdbck = new Feedbacktbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44353/api/Feedbacktbl/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    fdbck = JsonConvert.DeserializeObject<Feedbacktbl>(apiResponse);
                }
            }
            return View(fdbck);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateFeedback(Feedbacktbl f)
        {
            Feedbacktbl receivedemp = new Feedbacktbl();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = f.FeedId;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(f), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44353/api/Feedbacktbl?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<Feedbacktbl>(apiResponse);
                }
            }
            return RedirectToAction("ViewFeedback");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteFeedback(int id)
        {
            TempData["feedid"] = id;
            Feedbacktbl f = new Feedbacktbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44353/api/Feedbacktbl/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    f = JsonConvert.DeserializeObject<Feedbacktbl>(apiResponse);
                }
            }
            return View(f);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteFeedback(Feedbacktbl s)
        {
            int feedid = Convert.ToInt32(TempData["feedid"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44353/api/Feedbacktbl?id=" + feedid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewFeedback");
        }
    }
}
