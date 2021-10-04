using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class PartnerController : Controller
    {

        public static List<Partner> partners = new List<Partner>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Partner e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Partners.Add(e);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Subscription");
        }

        public IActionResult ViewPartner()
        {
            //ViewBag.Username = HttpContext.Session.GetString("username");
            using (var db = new NewspaperkartContext())
            {
                partners = db.Partners.ToList();
            }
            return View(partners);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Partner e = new Partner();
            using (var db = new NewspaperkartContext())
            {
                e = db.Partners.Find(id);
            }
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Partner e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Partner e = new Partner();
            using (var db = new NewspaperkartContext())
            {
                e = db.Partners.Find(id);
                //db.Subscriptions.Remove(e);
                //db.SaveChanges();
            }
            return View(e);
        }


        [HttpPost]
        public IActionResult Delete(Partner e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Partners.Remove(e);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
