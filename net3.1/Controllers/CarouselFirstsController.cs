using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using net3._1.Data;
using net3._1.Models;
using net3._1.Services;

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
