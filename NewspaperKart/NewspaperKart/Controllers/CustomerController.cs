using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
    public class CustomerController : Controller
    {

        string Token = "";

        IConfiguration _config;

        private IJsonSerializer _serializer = new JsonNetSerializer();
        private IDateTimeProvider _provider = new UtcDateTimeProvider();
        private IBase64UrlEncoder _urlEncoder = new JwtBase64UrlEncoder();
        private IJwtAlgorithm _algorithm = new HMACSHA256Algorithm();

        public CustomerController(IConfiguration config)
        {
            _config = config;
        }

        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CustomerController));

        string Baseurl = "https://localhost:44322/";


        [HttpGet]
        public IActionResult CustomerLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CustomerLogin(Customertbl c)
        {
            using (var client = new HttpClient())
            {
                StringContent c_content = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
                var response = client.PostAsync("https://localhost:44318/api/Authorization/Customer", c_content).Result;
                var response1 = client.PostAsync("https://localhost:44322/api/Customer/Login", c_content).Result;
                if (response.IsSuccessStatusCode)
                {
                    if (response1.IsSuccessStatusCode)
                    {
                        Token = response.Content.ReadAsStringAsync().Result;
                        HttpContext.Response.Cookies.Append("Token", Token);

                        string c1 = response1.Content.ReadAsStringAsync().Result;
                        Customertbl CustomerDetails = JsonConvert.DeserializeObject<Customertbl>(c1);

                        HttpContext.Session.SetString("CustUsername", CustomerDetails.UserName);
                        HttpContext.Session.SetInt32("CustUserId", CustomerDetails.CustomerId);
                        HttpContext.Session.SetString("CustAddress", CustomerDetails.Address);
                        HttpContext.Session.SetString("CustPhone", CustomerDetails.Phoneno);
                        IJwtValidator _validator = new JwtValidator(_serializer, _provider);
                        IJwtDecoder decoder = new JwtDecoder(_serializer, _validator, _urlEncoder, _algorithm);
                        var tokenExp = decoder.DecodeToObject<JwtTokenExp>(Token);
                        DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(tokenExp.exp);
                        DateTime timeExp = dateTimeOffset.LocalDateTime;

                        HttpContext.Response.Cookies.Append("Expiry", timeExp.ToString());
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return View();
                    }
                }
                return View();
            }
        }


        //[HttpGet]
        //public async Task<ActionResult> ViewProfile()
        //{
        //    _log4net.Info("Customer Controller - View method called");
        //    List<Customertbl> CustInfo = new List<Customertbl>();

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(Baseurl);

        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage Res = await client.GetAsync("https://localhost:44322/api/Customer");

        //        if (Res.IsSuccessStatusCode)
        //        {
        //            var CustResponse = Res.Content.ReadAsStringAsync().Result;

        //            CustInfo = JsonConvert.DeserializeObject<List<Customertbl>>(CustResponse);

        //        }
        //        return View(CustInfo);
        //    }
        //}

        [HttpGet]

        public async Task<ActionResult> ViewProfile(int id)
        {
            Customertbl cust = new Customertbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44322/api/Customer/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cust = JsonConvert.DeserializeObject<Customertbl>(apiResponse);
                }
            }
            return View(cust);
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCustomer(Customertbl c)
        {
            _log4net.Info("Customer Controller - Add method called");
            _log4net.Info("User " +c.Name + " Registered");
            Customertbl Custobj = new Customertbl();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:44322/api/Customer", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Custobj = JsonConvert.DeserializeObject<Customertbl>(apiResponse);
                }
            }
            return RedirectToAction("UserLogin", "Register");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateCustomer(int id)
        {
            Customertbl cust = new Customertbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44322/api/Customer/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cust = JsonConvert.DeserializeObject<Customertbl>(apiResponse);
                }
            }
            return View(cust);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateCustomer(Customertbl c)
        {
            Customertbl receivedemp = new Customertbl();

            using (var httpClient = new HttpClient())
            {
                #region
                #endregion
                int id = c.CustomerId;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(c), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync("https://localhost:44322/api/Customer?id=" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<Customertbl>(apiResponse);
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            TempData["custid"] = id;
            Customertbl c = new Customertbl();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44322/api/Customer/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    c = JsonConvert.DeserializeObject<Customertbl>(apiResponse);
                }
            }
            return View(c);
        }


        [HttpPost]
        public async Task<ActionResult> DeleteCustomer(Customertbl c)
        {
            int custid = Convert.ToInt32(TempData["custid"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44322/api/Customer?id=" + custid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }


        public IActionResult CustomerLogout()
        {
            if (Request.Cookies["Token"] != null)
            {
                Response.Cookies.Delete("Token");
            }
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Demo");
        }

    }
}
