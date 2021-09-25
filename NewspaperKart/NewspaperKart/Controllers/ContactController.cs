using Microsoft.AspNetCore.Mvc;
using NewspaperKart.CTSModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class ContactController : Controller
    {

        public static List<Contact> contacts = new List<Contact>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Contacts.Add(e);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ViewContact()
        {
            //ViewBag.Username = HttpContext.Session.GetString("username");
            using (var db = new NewspaperkartContext())
            {
                contacts = db.Contacts.ToList();
            }
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Contact e = new Contact();
            using (var db = new NewspaperkartContext())
            {
                e = db.Contacts.Find(id);
            }
            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Contact e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Entry(e).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

            }
            return RedirectToAction("ViewContact");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Contact e = new Contact();
            using (var db = new NewspaperkartContext())
            {
                e = db.Contacts.Find(id);
                //db.Subscriptions.Remove(e);
                //db.SaveChanges();
            }
            return View(e);
        }


        [HttpPost]
        public IActionResult Delete(Contact e)
        {
            using (var db = new NewspaperkartContext())
            {
                db.Contacts.Remove(e);
                db.SaveChanges();
            }

            return RedirectToAction("ViewContact");
        }


    }
}
