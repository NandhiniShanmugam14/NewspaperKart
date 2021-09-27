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
    public class AdminController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AdminController));

        string Baseurl = "https://localhost:44394/";
        [HttpGet]
        public async Task<ActionResult> ViewAdmin()
        {
            _log4net.Info("Admin Controller - View method called");
            List<Admintbl> adminInfo = new List<Admintbl>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Admin");

                if (Res.IsSuccessStatusCode)
                {
                    var CustResponse = Res.Content.ReadAsStringAsync().Result;

                    adminInfo = JsonConvert.DeserializeObject<List<Admintbl>>(CustResponse);

                }
                return View(adminInfo);
            }
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddAdmin(Admintbl c)
        {
            _log4net.Info("Admin Controller - Add method called");
            _log4net.Info("User " + c.Name + " Registered");

            Admintbl Adobj = new Admintbl();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44394/api/Admin/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Adobj = JsonConvert.DeserializeObject<Admintbl>(apiResponse);
                }
            }
            return RedirectToAction("AdminLogin", "Register");
        }

        //[HttpGet]
        //public async Task<ActionResult> UpdateAdmin(int id)
        //{
        //    Customertbl cust = new Customertbl();
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync("https://localhost:44394/api/Admin/" + id))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            cust = JsonConvert.DeserializeObject<Customertbl>(apiResponse);
        //        }
        //    }
        //    return View(cust);
        //}

        //[HttpPost]
        //public async Task<ActionResult> UpdateAdmin(Customertbl c)
        //{
        //    Customertbl receivedemp = new Customertbl();

        //    using (var httpClient = new HttpClient())
        //    {
        //        #region
        //        #endregion
        //        int id = c.CustomerId;
        //        StringContent content1 = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
        //        using (var response = await httpClient.PutAsync("https://localhost:44394/api/Admin?id=" + id, content1))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            ViewBag.Result = "Success";
        //            receivedemp = JsonConvert.DeserializeObject<Customertbl>(apiResponse);
        //        }
        //    }
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public async Task<ActionResult> DeleteAdmin(int id)
        //{
        //    TempData["custid"] = id;
        //    Customertbl c = new Customertbl();
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.GetAsync("https://localhost:44394/api/Admin/" + id))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            c = JsonConvert.DeserializeObject<Customertbl>(apiResponse);
        //        }
        //    }
        //    return View(c);
        //}


        //[HttpPost]
        //public async Task<ActionResult> DeleteAdmin(Customertbl c)
        //{
        //    int custid = Convert.ToInt32(TempData["custid"]);
        //    using (var httpClient = new HttpClient())
        //    {
        //        using (var response = await httpClient.DeleteAsync("https://localhost:44394/api/Admin?id=" + custid))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //        }
        //    }

        //    return RedirectToAction("Index");
        //}

    }
}
