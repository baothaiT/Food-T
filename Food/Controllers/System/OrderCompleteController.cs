using Food.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Controllers.System
{
    public class OrderCompleteController : Controller
    {

        private readonly ApplicationDbContext _context;


        public OrderCompleteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("/OrderComplete")]
        [HttpGet]
        public IActionResult Index()
        {
            //Count product in cart page
            var queryCart = _context.CartsDevice;
            ViewBag.CountProductInCart = queryCart.Count();



            return View();
        }
    }
}
