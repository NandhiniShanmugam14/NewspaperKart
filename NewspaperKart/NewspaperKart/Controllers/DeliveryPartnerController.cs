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
    public class DeliveryPartnerController : Controller
    {
        string Baseurl = "https://localhost:44340/";

        [HttpGet]
        public async Task<ActionResult> ViewDeliveryPartner()
        {
            List<DeliveryPartnertbl> DelPartInfo = new List<DeliveryPartnertbl>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Deliveryp");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    DelPartInfo = JsonConvert.DeserializeObject<List<DeliveryPartnertbl>>(SubsResponse);

                }
                return View(DelPartInfo);
            }
        }

        [HttpGet]
        public ActionResult AddDeliveryPartner()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddDeliveryPartner(DeliveryPartnertbl d)
        {
            DeliveryPartnertbl DelPartobj = new DeliveryPartnertbl();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44340/api/Deliveryp/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    DelPartobj = JsonConvert.DeserializeObject<DeliveryPartnertbl>(apiResponse);
                }
            }
            return RedirectToAction("ViewDeliveryPartner");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateDeliveryPartner(int id)
        {
            DeliveryPartnertbl delpart = new DeliveryPartnertbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44340/api/Deliveryp/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    delpart = JsonConvert.DeserializeObject<DeliveryPartnertbl>(apiResponse);
                }
            }
            return View(delpart);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateDeliveryPartner(DeliveryPartnertbl d)
        {
            DeliveryPartnertbl receivedemp = new DeliveryPartnertbl();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = d.DelPartId;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(d), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44340/api/Deliveryp?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    //receivedemp = JsonConvert.DeserializeObject<DeliveryPartnertbl>(apiResponse);
                }
            }
            return RedirectToAction("ViewDeliveryPartner");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteDeliveryPartner(int id)
        {
            TempData["delpartid"] = id;
            DeliveryPartnertbl d = new DeliveryPartnertbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44340/api/Deliveryp/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    d = JsonConvert.DeserializeObject<DeliveryPartnertbl>(apiResponse);
                }
            }
            return View(d);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteDeliveryPartner(DeliveryPartnertbl d)
        {
            int delpartid = Convert.ToInt32(TempData["delpartid"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44340/api/Deliveryp?id=" + delpartid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewDeliveryPartner");
        }
    }
}
