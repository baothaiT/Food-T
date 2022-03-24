using Food.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Food.Models;

namespace Food.Controllers.System
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SearchController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SearchController/Details/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(SearchModel searchModel)
        {

            return Redirect("/food?searchName="+ searchModel.searchName);
        }

        // GET: SearchController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SearchController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SearchController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SearchController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SearchController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SearchController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
