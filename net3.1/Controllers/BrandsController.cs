using Microsoft.AspNetCore.Mvc;
using net3._1.Models;
using net3._1.Services;
using System.Collections.Generic;

namespace net3._1.Controllers
{
    public class BrandsController : Controller
    {
        private readonly CarouselServices _backend;
        public BrandsController(CarouselServices backend)
        {
            _backend = backend;
        }

        public ActionResult<List<Brand>> GetAllBrands()
        {
            var lst = _backend.GetBrands();

            if (lst == null) return NotFound();

            return lst;
        }
    }
}
