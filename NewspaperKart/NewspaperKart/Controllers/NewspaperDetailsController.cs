using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewspaperKart.Controllers
{
    public class NewspaperDetailsController : Controller
    {
        public IActionResult TimesOfIndia()
        {
            return View();
        }

        public IActionResult Indianera()
        {
            return View();
        }

        public IActionResult TheHindu()
        {
            return View();
        }
        public IActionResult HindustanTimes()
        {
            return View();
        }
        public IActionResult EconomicalTimes()
        {
            return View();
        }
        public IActionResult DeccanChronicle()
        {
            return View();
        }
        public IActionResult BusinessStandard()
        {
            return View();
        }
        public IActionResult IndianExpress()
        {
            return View();
        }
    }
}
