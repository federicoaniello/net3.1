using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net3._1.Models;
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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
            return View();
        }

        public PartialViewResult CarouselFirst()
        {
            List<CarouselFirst> carousels = new List<CarouselFirst>()
            {
                 new CarouselFirst("gallery-desktop-01.jpg","gallery-mobile-01.jpg"),
                 new CarouselFirst("gallery-desktop-02.jpg","gallery-mobile-02.jpg"),
                 new CarouselFirst("gallery-desktop-03.jpg","gallery-mobile-03.jpg"),
                 new CarouselFirst("gallery-desktop-04.jpg","gallery-mobile-04.jpg"),
                 new CarouselFirst("gallery-desktop-05.jpg","gallery-mobile-05.jpg"),
                 new CarouselFirst("gallery-desktop-06.jpg","gallery-mobile-06.jpg"),
                 new CarouselFirst("gallery-desktop-07.jpg","gallery-mobile-07.jpg"),
                 new CarouselFirst("gallery-desktop-08.jpg","gallery-mobile-08.jpg"),
            };
            return PartialView(carousels );
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
