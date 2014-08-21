using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models02.Models;

namespace Models02.Controllers
{
    public class CommentsController : Controller
    {
        private ConferenceContext db = new ConferenceContext();

        public PartialViewResult _GetForSession(Int32 sessionID)
        {
            ViewBag.SessionID = sessionID;
            List<Comment> comments = db.Comments.Where(c => c.SessionID == sessionID).ToList();
            return PartialView("_GetForSession", comments);
        }

        [ChildActionOnly()]
        public PartialViewResult _CommentForm(Int32 sessionID)
        {
            Comment comment = new Comment() { SessionID = sessionID};
            return PartialView("_CommentForm", comment);
        }

        [ValidateAntiForgeryToken]
        public PartialViewResult _Submit(Comment comment)
        {
                db.Comments.Add(comment);
                db.SaveChanges();

                List<Comment> comments = db.Comments.Where(c => c.SessionID 
                    == comment.SessionID).ToList();
                ViewBag.SessionID = comment.SessionID;
                return PartialView("_GetForSession", comments);
        }


    }
}
