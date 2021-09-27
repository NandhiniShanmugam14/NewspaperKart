using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewspaperKart.Controllers
{
    public class NewspaperDetailsController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(NewspaperDetailsController));
        public IActionResult TimesOfIndia()
        {
            _log4net.Info("NewspaperDetails Controller - Times of India");
            return View();
        }

        public IActionResult Indianera()
        {
            _log4net.Info("NewspaperDetails Controller - Indian Era");
            return View();
        }

        public IActionResult TheHindu()
        {
            _log4net.Info("NewspaperDetails Controller - The Hindu");
            return View();
        }
        public IActionResult HindustanTimes()
        {
            _log4net.Info("NewspaperDetails Controller - Hindustan Times");
            return View();
        }
        public IActionResult EconomicalTimes()
        {
            _log4net.Info("NewspaperDetails Controller - Economical Times");
            return View();
        }
        public IActionResult DeccanChronicle()
        {
            _log4net.Info("NewspaperDetails Controller - Deccan Chronicle");
            return View();
        }
        public IActionResult BusinessStandard()
        {
            _log4net.Info("NewspaperDetails Controller - Business Standard");
            return View();
        }
        public IActionResult IndianExpress()
        {
            _log4net.Info("NewspaperDetails Controller - Indian Express");
            return View();
        }
    }
}
