using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession session;

        public LoginController(IHttpContextAccessor httpContextAccessor)
        {
            session = httpContextAccessor.HttpContext.Session;
        }

        [HttpGet]
        public IActionResult Login()
        {
            //return RedirectToAction("Index", "Admin");
            return View();

        }

        [HttpPost]
        public IActionResult Login(Logintbl l)
        {
            using (var db = new NewspaperkartContext())
            {
                HttpContext.Session.SetString("username", l.Username);
                Logintbl result = (from i in db.Logintbls
                                   where i.Username == l.Username && i.Password == l.Password
                                   select i).FirstOrDefault();
                

                if (result != null)

                {
                    HttpContext.Session.SetString("username", l.Username);
                    if (l.Username == "Admin")
                    {
                        return RedirectToAction("Admin", "Home");

                    }
                    else if(l.Username == "Vendor")
                    {
                        return RedirectToAction("Vendor", "Home");

                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");

                    }
                }

                
                else
                {
                    return View();
                }
            }

        }



        [HttpPost]
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        //register

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Logintbl user)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Logintbls.Add(user);
                db.SaveChanges();
            }
            return RedirectToAction("Login");
        }
    }
}
