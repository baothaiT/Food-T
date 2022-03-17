using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Controllers.System
{
    public class OrderCompleteController : Controller
    {


        [Route("/OrderComplete")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
