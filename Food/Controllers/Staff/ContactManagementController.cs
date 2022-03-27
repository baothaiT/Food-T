using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers.Staff
{
    public class ContactManagementController : Controller
    {
        [Route("/contactmanagement")]
        // GET: ContactManagementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactManagementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactManagementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactManagementController/Create
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

        // GET: ContactManagementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactManagementController/Edit/5
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

        // GET: ContactManagementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactManagementController/Delete/5
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
