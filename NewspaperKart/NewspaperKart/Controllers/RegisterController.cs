using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;

namespace NewspaperKart.Controllers
{
    public class RegisterController : Controller
    {
        public static List<UserRegistertbl> user = new List<UserRegistertbl>();
        public static List<AdminRegistertbl> admin = new List<AdminRegistertbl>();

        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpPost]

        public IActionResult UserRegister(UserRegistertbl u)
        {
            using (var db = new NewspaperkartContext())
            {
                db.UserRegistertbls.Add(u);
                db.SaveChanges();
            }
            return RedirectToAction("UserLogin");
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]

        public IActionResult UserLogin(UserRegistertbl u)
        {
            using (var db = new NewspaperkartContext())
            {
                UserRegistertbl result = (from i in db.UserRegistertbls where i.Name == u.Name && i.Password == u.Password select i).FirstOrDefault();

                if(result!=null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        [HttpGet]

        public IActionResult AdminRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminRegister(AdminRegistertbl a)
        {
            using (var db = new NewspaperkartContext())
            {
                db.AdminRegistertbls.Add(a);
                db.SaveChanges();
            }
            return RedirectToAction("AdminLogin");
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminRegistertbl a)
        {
            using (var db = new NewspaperkartContext())
            {
                AdminRegistertbl result = (from i in db.AdminRegistertbls where i.Name == a.Name && i.Password == a.Password select i).FirstOrDefault();

                if(result != null)
                {
                    return RedirectToAction("Admin", "Home");
                }
                else
                {
                    return View();
                }
            }
        }

        [HttpGet]
        public IActionResult VendorRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VendorRegister(VendorRegistertbl v)
        {
            using (var db = new NewspaperkartContext())
            {
                db.VendorRegistertbls.Add(v);
                db.SaveChanges();
            }
            return RedirectToAction("VendorLogin");
        }

        [HttpGet]
        public IActionResult VendorLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VendorLogin(VendorRegistertbl v)
        {
            using (var db = new NewspaperkartContext())
            {
                VendorRegistertbl result = (from i in db.VendorRegistertbls where i.Name == v.Name && i.Password == v.Password select i).FirstOrDefault();

                if(result != null)
                {
                    return RedirectToAction("Vendor", "Home");
                }
                else
                {
                    return View();
                }
            }
        }

    }
}
