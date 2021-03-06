using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NewspaperKart.Models;
using Newtonsoft.Json;

namespace NewspaperKart.Controllers
{
    public class VendorController : Controller
    {

        string Token = "";

        IConfiguration _config;

        private IJsonSerializer _serializer = new JsonNetSerializer();
        private IDateTimeProvider _provider = new UtcDateTimeProvider();
        private IBase64UrlEncoder _urlEncoder = new JwtBase64UrlEncoder();
        private IJwtAlgorithm _algorithm = new HMACSHA256Algorithm();

        public VendorController(IConfiguration config)
        {
            _config = config;
        }


        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(VendorController));

        //string Baseurl = "https://localhost:44325/";



        [HttpGet]
        public IActionResult VendorLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VendorLogin(Vendortbl v)
        {
            using (var client = new HttpClient())
            {
                StringContent c_content = new StringContent(JsonConvert.SerializeObject(v), Encoding.UTF8, "application/json");
                var response = client.PostAsync("https://localhost:44318/api/Authorization/Vendor", c_content).Result;
                var response1 = client.PostAsync("https://localhost:44325/api/Vendor/Login", c_content).Result;
                if (response.IsSuccessStatusCode)
                {
                    if (response1.IsSuccessStatusCode)
                    {
                        Token = response.Content.ReadAsStringAsync().Result;
                        HttpContext.Response.Cookies.Append("Token", Token);

                        string c1 = response1.Content.ReadAsStringAsync().Result;
                        Vendortbl VendorDetails = JsonConvert.DeserializeObject<Vendortbl>(c1);

                        HttpContext.Session.SetString("VendorUsername", VendorDetails.UserName);
                        HttpContext.Session.SetInt32("VendorUserId", VendorDetails.VendorId);

                        IJwtValidator _validator = new JwtValidator(_serializer, _provider);
                        IJwtDecoder decoder = new JwtDecoder(_serializer, _validator, _urlEncoder, _algorithm);
                        var tokenExp = decoder.DecodeToObject<JwtTokenExp>(Token);
                        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(tokenExp.exp);
                        DateTime timeExp = dateTimeOffset.LocalDateTime;

                        HttpContext.Response.Cookies.Append("Expiry", timeExp.ToString());
                        return RedirectToAction("Vendor", "Home");
                    }
                    else
                    {
                        return View();
                    }
                }
                return View();
            }
        }

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

        public IActionResult VendorLogout()
        {
            if (Request.Cookies["Token"] != null)
            {
                Response.Cookies.Delete("Token");
            }
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Demo");
        }


        string Baseurl = "https://localhost:44337/";

        [HttpGet]
        public async Task<ActionResult> ViewVendor()
        {
            _log4net.Info("Vendot Controller - View Vendor method called");
            List<Vendortbl> SubsInfo = new List<Vendortbl>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("https://localhost:44325/api/Vendor/");

                if (Res.IsSuccessStatusCode)
                {
                    var SubsResponse = Res.Content.ReadAsStringAsync().Result;

                    SubsInfo = JsonConvert.DeserializeObject<List<Vendortbl>>(SubsResponse);

                }
                return View(SubsInfo);
            }
        }


        [HttpGet]
        public async Task<ActionResult> DeleteVendor(int id)
        {
            TempData["Venid"] = id;
            Vendortbl s = new Vendortbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44325/api/Vendor/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    s = JsonConvert.DeserializeObject<Vendortbl>(apiResponse);
                }
            }
            return View(s);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteVendor(Vendortbl v)
        {
            _log4net.Info("Vendor Controller - Delete method called");
            int Venid = Convert.ToInt32(TempData["Venid"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44325/api/Vendor?id=" + Venid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("ViewVendor");
        }
    }
}
