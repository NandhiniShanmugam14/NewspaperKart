using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewspaperKart.CTSModel;
using NewspaperKart.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewspaperKart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(HomeController));

        public static List<Newspaper> newspapers = new List<Newspaper>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _log4net.Info("Home Controller - Index method called");
            return View();
        }

        public IActionResult Admin()
        {
            _log4net.Info("Home Controller - Admin method called");
            return View();
        }

        public IActionResult Vendor()
        {
            _log4net.Info("Home Controller - Vendor method called");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       


        
    }
}
