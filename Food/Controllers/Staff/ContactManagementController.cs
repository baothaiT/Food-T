﻿using Food.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Food.Controllers.Staff
{
    [Authorize(Roles = "Admin,Staff")]
    public class ContactManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ContactManagementController
        [Route("/contactmanagement")]
        [HttpGet]
        public ActionResult Index()
        {
            var query = _context.ContactUsers;
            return View(query);
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
