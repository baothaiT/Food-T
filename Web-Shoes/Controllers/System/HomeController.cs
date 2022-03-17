using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Food.Data;
using Food.Models;

namespace Food.Controllers.System
{
    public class HomeController : Controller
    {
        // Database
        private readonly ApplicationDbContext _context;
        public HomeController( ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Print list product in Home Page
            var HomeProductQuery = from a in _context.Products select a;
            return View(HomeProductQuery);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
