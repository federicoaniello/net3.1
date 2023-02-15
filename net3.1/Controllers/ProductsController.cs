using Microsoft.AspNetCore.Mvc;
using net3._1.Data;
using net3._1.Models;
using net3._1.Services;
using System.Collections.Generic;

namespace net3._1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly net3_1Context _context;
        private readonly CarouselServices _backend;
        public ProductsController(net3_1Context context, CarouselServices backend)
        {
            _context = context;
            _backend = backend;
        }

        public JsonResult GetAllProducts()
        {
            var lst = _backend.GetProducts();

            return Json(lst);
        }
    }
}
