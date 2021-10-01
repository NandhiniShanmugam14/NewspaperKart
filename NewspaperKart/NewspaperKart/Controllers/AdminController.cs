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
    public class AdminController : Controller
    {

        string Token = "";

        IConfiguration _config;

        private IJsonSerializer _serializer = new JsonNetSerializer();
        private IDateTimeProvider _provider = new UtcDateTimeProvider();
        private IBase64UrlEncoder _urlEncoder = new JwtBase64UrlEncoder();
        private IJwtAlgorithm _algorithm = new HMACSHA256Algorithm();

        public AdminController(IConfiguration config)
        {
            _config = config;
        }


        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AdminController));

        string Baseurl = "https://localhost:44394/";


        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminLogin(Admintbl a)
        {
            using (var client = new HttpClient())
            {
                StringContent c_content = new StringContent(JsonConvert.SerializeObject(a), Encoding.UTF8, "application/json");
                var response = client.PostAsync("https://localhost:44318/api/Authorization/Admin", c_content).Result;
                var response1 = client.PostAsync("https://localhost:44394/api/Admin/Login", c_content).Result;
                if (response.IsSuccessStatusCode)
                {
                    if (response1.IsSuccessStatusCode)
                    {
                        Token = response.Content.ReadAsStringAsync().Result;
                        HttpContext.Response.Cookies.Append("Token", Token);

                        string c1 = response1.Content.ReadAsStringAsync().Result;
                        Admintbl AdminDetails = JsonConvert.DeserializeObject<Admintbl>(c1);

                        HttpContext.Session.SetString("AdminUsername", AdminDetails.UserName);
                        HttpContext.Session.SetInt32("AdminUserId", AdminDetails.AdminId);

                        IJwtValidator _validator = new JwtValidator(_serializer, _provider);
                        IJwtDecoder decoder = new JwtDecoder(_serializer, _validator, _urlEncoder, _algorithm);
                        var tokenExp = decoder.DecodeToObject<JwtTokenExp>(Token);
                        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(tokenExp.exp);
                        DateTime timeExp = dateTimeOffset.LocalDateTime;

                        HttpContext.Response.Cookies.Append("Expiry", timeExp.ToString());
                        return RedirectToAction("Admin", "Home");
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

         public IActionResult AdminLogout()
        {
            if (Request.Cookies["Token"] != null)
            {
                Response.Cookies.Delete("Token");
            }
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Demo");
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
