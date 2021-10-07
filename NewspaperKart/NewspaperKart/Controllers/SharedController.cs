using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class SharedController : Controller
    {
        private readonly ISession session;

        public SharedController(IHttpContextAccessor httpContextAccessor)
        {
            session = httpContextAccessor.HttpContext.Session;
        }


        //public IActionResult _layout(Logintbl l)
        //{
        //    using (var db = new NewspaperkartContext())
        //    {
        //        Logintbl result = (from i in db.Logintbls
        //                           where i.Username == l.Username && i.Password == l.Password
        //                           select i).FirstOrDefault();
        //        ViewBag.Username = HttpContext.Session.GetString("username");


        //        return View();
        //    }
        //}

        //[HttpPost]
        //public IActionResult _layout(Logintbl l)
        //{
        //    using (var db = new NewspaperkartContext())
        //    {
        //        Logintbl result = (from i in db.Logintbls
        //                           where i.Username == l.Username && i.Password == l.Password
        //                           select i).FirstOrDefault();

        //    }


        //}
    }
}
