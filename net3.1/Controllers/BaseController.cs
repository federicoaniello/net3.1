using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using net3._1.Services;
using Microsoft.Extensions.DependencyInjection;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace net3._1.Controllers
{
    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {

        private CarouselServices carouselServices;

        protected CarouselServices Crs => carouselServices ??= HttpContext.RequestServices.GetService<CarouselServices>();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            ViewBag.HeaderData = Crs.GetHeaderTabs();
        }
    }
}

