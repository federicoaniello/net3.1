using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using net3._1.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace net3._1.Controllers
{
    public class BaseController : Controller
    {

        protected readonly CarouselServices carouselServices;

        protected BaseController(CarouselServices carouselServices)
        {
            this.carouselServices = carouselServices;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            ViewBag.HeaderData = carouselServices.GetHeaderTabs();
        }
    }
}

