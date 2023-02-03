using Microsoft.AspNetCore.Mvc;
using net3._1.Models;
using net3._1.Services;
using System.Collections.Generic;

namespace net3._1.Controllers
{
    public class CarouselFirstsController : Controller
    {
        private readonly CarouselServices _backend;

        public CarouselFirstsController(CarouselServices backend)
        {
            _backend = backend;
        }


        public ActionResult<List<CarouselFirst>> GetAllCarousels()
        {
            var lst = _backend.GetCarouselList();

            if (lst == null) return NotFound();

            return lst;
        }



    }
}
