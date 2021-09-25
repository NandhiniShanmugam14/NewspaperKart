using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class AddDeliveryPartnerController : Controller
    {
        public static List<AddDelivery> addDeliveries = new List<AddDelivery>();
        public IActionResult AddDeliveryPartner()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDeliveryPartner(AddDelivery e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.AddDeliveries.Add(e);
                db.SaveChanges();
            }
            return RedirectToAction("Vendor", "Home");
        }

        public IActionResult ViewDeliveryDetails()
        {
            //ViewBag.Username = HttpContext.Session.GetString("username");
            using (var db = new NewspaperkartContext())
            {
                addDeliveries = db.AddDeliveries.ToList();
            }
            return View(addDeliveries);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            AddDelivery e = new AddDelivery();
            using (var db = new NewspaperkartContext())
            {
                e = db.AddDeliveries.Find(id);
            }
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(AddDelivery e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            }
            return RedirectToAction("ViewDeliveryDetails");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            AddDelivery e = new AddDelivery();
            using (var db = new NewspaperkartContext())
            {
                e = db.AddDeliveries.Find(id);
                //db.Subscriptions.Remove(e);
                //db.SaveChanges();
            }
            return View(e);
        }


        [HttpPost]
        public IActionResult Delete(AddDelivery e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.AddDeliveries.Remove(e);
                db.SaveChanges();
            }

            return RedirectToAction("ViewDeliveryDetails");
        }
    }
}
