using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net3._1.Data;
using net3._1.Models;
using net3._1.Services;
using System.Diagnostics;

namespace net3._1.Controllers
{
    public class HomeController : BaseController<HomeController>
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarouselServices _carouselServices;
        private readonly net3_1Context _context;

        public HomeController(ILogger<HomeController> logger, CarouselServices carouselServices, net3_1Context context)
        {
            _logger = logger;
            _carouselServices = carouselServices;
            _context = context;
        }


     

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Privacy()
        {
            return View();
        }
        public ViewResult Page()
        {

            var HomePage = new HomePageViewModel
            {
                carousels = _carouselServices.GetCarouselList(),
                showCases = _carouselServices.GetShowCases()
            };



            return View(HomePage);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
