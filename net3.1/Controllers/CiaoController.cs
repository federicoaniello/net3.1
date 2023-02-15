using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net3._1.Controllers
{
    public class CiaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
