using Food.Data;
using Food.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Food.Controllers.System
{
    public class SubscribeOurNewsletterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubscribeOurNewsletterController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SubscribeOurNewsletterController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SubscribeOurNewsletterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // POST: SubscribeOurNewsletterController/Create
        [HttpPost]
        [Route("subscribeemail")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SubscribeEmail subscribeEmail)
        {
            try
            {
                //string Nickname = Request.Form["inpNickname"];
                var contactCreate = new SubscribeEmail()
                {
                    Id = Guid.NewGuid().ToString(),
                    Email = subscribeEmail.Email,
                };

                _context.SubscribeEmail.Add(contactCreate);
                _context.SaveChanges();

                return Redirect("/");
            }
            catch
            {
                return View();
            }
        }

        // GET: SubscribeOurNewsletterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubscribeOurNewsletterController/Edit/5
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

        // GET: SubscribeOurNewsletterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubscribeOurNewsletterController/Delete/5
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
