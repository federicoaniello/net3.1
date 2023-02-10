using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using net3._1.Models;
using net3._1.Services;
using System.Collections.Generic;

namespace net3._1.Controllers
{
    public class HeaderController : Controller
    {
        private readonly CarouselServices _backend;
        public HeaderController( CarouselServices _backend)
        {
            this._backend= _backend;
        }

        // GET: Header/GetAllHeaderTabs
        public ActionResult<Dictionary<TabKey, TabValue[]>> GetAllHeaderTabs()
        {
            return _backend.GetHeaderTabs();
        }






  

    }
}
