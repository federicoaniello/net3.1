using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net3._1.Models;
using net3._1.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace net3._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarouselServices _carouselServices;
        public HomeController(ILogger<HomeController> logger, CarouselServices carouselServices)
        {
            _logger = logger;
            _carouselServices = carouselServices;
        }

        public ActionResult Index()
        {
             return View();
        }

        public IActionResult Privacy()
        {
            return View(); 
        }
        public IActionResult Page()
        {

            var HomePage = new HomePageViewModel();
            HomePage.carousels = _carouselServices.GetCarouseLList();
            HomePage.showCases = _carouselServices.GetShowCases();
            HomePage.products = _carouselServices.GetProducts();
            return View( HomePage );
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
