using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewspaperKart.Models;
using Newtonsoft.Json;

namespace NewspaperKart.Controllers
{
    public class AddDeliveryController : Controller
    {

        string Baseurl = "https://localhost:44398/";

        [HttpGet]
        public async Task<ActionResult> ViewDelivery()
        {
            List<AddDeliverytbl> DeliveryInfo = new List<AddDeliverytbl>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/AddDelivery");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    DeliveryInfo = JsonConvert.DeserializeObject<List<AddDeliverytbl>>(SubsResponse);

                }
                return View(DeliveryInfo);
            }
        }

        [HttpGet]
        public async Task<ActionResult> AddDelivery()
        {
            List<SelectListItem> DropDownList = new List<SelectListItem>();
            List<DeliveryPartnertbl> SpecializationList = new List<DeliveryPartnertbl>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44340/api/Deliveryp"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    SpecializationList = JsonConvert.DeserializeObject<List<DeliveryPartnertbl>>(apiResponse);
                }
            }
            foreach (var item in SpecializationList)
            {
                DropDownList.Add(new SelectListItem() { Text = item.Name, Value = item.Name });
            }
            ViewBag.specialization = DropDownList;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddDelivery(AddDeliverytbl a)
        {
            AddDeliverytbl Delobj = new AddDeliverytbl();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(a), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44398/api/AddDelivery/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Delobj = JsonConvert.DeserializeObject<AddDeliverytbl>(apiResponse);
                }
            }
            return RedirectToAction("ViewDelivery");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateDelivery(int id)
        {
            AddDeliverytbl del = new AddDeliverytbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44398/api/AddDelivery/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    del = JsonConvert.DeserializeObject<AddDeliverytbl>(apiResponse);
                }
            }
            return View(del);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateDelivery(AddDeliverytbl a)
        {
            AddDeliverytbl receivedemp = new AddDeliverytbl();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = a.DelId;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(a), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44398/api/AddDelivery?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<AddDeliverytbl>(apiResponse);
                }
            }
            return RedirectToAction("ViewDelivery");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteDelivery(int id)
        {
            TempData["DelId"] = id;
            AddDeliverytbl a = new AddDeliverytbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44398/api/AddDelivery/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    a = JsonConvert.DeserializeObject<AddDeliverytbl>(apiResponse);
                }
            }
            return View(a);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteDelivery(AddDeliverytbl a)
        {
            int id = Convert.ToInt32(TempData["DelId"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44398/api/AddDelivery?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewDelivery");
        }
    }
}
