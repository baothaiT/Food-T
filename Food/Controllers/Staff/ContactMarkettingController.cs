﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers.Staff
{
    public class ContactMarkettingController : Controller
    {
        [Route("/contactmarketting")]
        // GET: ContactMarkettingController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ContactMarkettingController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactMarkettingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactMarkettingController/Create
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

        // GET: ContactMarkettingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactMarkettingController/Edit/5
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

        // GET: ContactMarkettingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactMarkettingController/Delete/5
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
