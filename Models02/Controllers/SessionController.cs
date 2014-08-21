using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models02.Models;

namespace Models02.Controllers
{
    public class SessionController : Controller
    {
        // GET: Session
        public ActionResult Index()
        {
            var context = new ConferenceContext();
            var sessions = context.Sessions.ToList();
            return View("Index", sessions);
        }

        // GET: Session
        public ActionResult Details()
        {
            var context = new ConferenceContext();
            var session = new Session();
            return View("Details", session);
        }

        [HttpGet()]
        [Authorize(Roles="Administrators")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Session session)
        {
            // validate decorated properties
            if (!ModelState.IsValid)
            {
                return View(session);                
            }

            try
            {
                ConferenceContext context = new ConferenceContext();
                context.Sessions.Add(session);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error",ex.Message);
                return View(session);
            }


            TempData["Message"] = "Created " + session.Title;
            return RedirectToAction("Index");
        }
    }
}