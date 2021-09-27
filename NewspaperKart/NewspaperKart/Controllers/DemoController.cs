using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class DemoController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(DemoController));

        public IActionResult Index()
        {
            _log4net.Info("Demo Controller - Index method called(Home Page)");
            return View();
        }
    }
}
