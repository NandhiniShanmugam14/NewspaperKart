using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class DeliveryController : Controller
    {
        public static List<Delivery> deliveries = new List<Delivery>();
        public IActionResult AddDelivery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDelivery(Delivery e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Deliveries.Add(e);
                db.SaveChanges();
            }
            return RedirectToAction("Vendor", "Home");
        }

        public IActionResult ViewDelivery()
        {
            //ViewBag.Username = HttpContext.Session.GetString("username");
            using (var db = new NewspaperkartContext())
            {
                deliveries = db.Deliveries.ToList();
            }
            return View(deliveries);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Delivery e = new Delivery();
            using (var db = new NewspaperkartContext())
            {
                e = db.Deliveries.Find(id);
            }
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Delivery e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            }
            return RedirectToAction("ViewDelivery");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Delivery e = new Delivery();
            using (var db = new NewspaperkartContext())
            {
                e = db.Deliveries.Find(id);
                //db.Subscriptions.Remove(e);
                //db.SaveChanges();
            }
            return View(e);
        }


        [HttpPost]
        public IActionResult Delete(Delivery e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Deliveries.Remove(e);
                db.SaveChanges();
            }

            return RedirectToAction("ViewDelivery");
        }
    }
}
