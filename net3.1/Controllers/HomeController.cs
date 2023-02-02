﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net3._1.Data;
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
        private readonly net3_1Context _context;

        public HomeController(ILogger<HomeController> logger, CarouselServices carouselServices, net3_1Context context)
        {
            _logger = logger;
            _carouselServices = carouselServices;
            _context = context;
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
            HomePage.carousels = _context.CarouselFirst.ToList<CarouselFirst>();
            HomePage.showCases = _carouselServices.GetShowCases();
            HomePage.products = _carouselServices.GetProducts();
            HomePage.brands = _carouselServices.GetBrands();
            return View( HomePage );
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
