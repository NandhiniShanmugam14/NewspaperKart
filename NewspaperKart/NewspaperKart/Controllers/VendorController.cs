using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewspaperKart.Models;
using Newtonsoft.Json;

namespace NewspaperKart.Controllers
{
    public class VendorController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(VendorController));

        //string Baseurl = "https://localhost:44325/";

        [HttpGet]
        public ActionResult AddVendor()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddVendor(Vendortbl v)
        {
            _log4net.Info("Vendor Controller - Add method called");
            _log4net.Info("User " +v.UserName + " Registered");
            Vendortbl Venobj = new Vendortbl();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(v), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44325/api/Vendor/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Venobj = JsonConvert.DeserializeObject<Vendortbl>(apiResponse);
                }
            }
            return RedirectToAction("VendorLogin", "Register");
        }
    }
}
