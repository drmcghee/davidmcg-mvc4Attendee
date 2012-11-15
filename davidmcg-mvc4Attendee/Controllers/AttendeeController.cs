using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using davidmcg_mvc4Attendee.Models;

namespace davidmcg_mvc4Attendee.Controllers
{
    public class AttendeeController : Controller
    {
        private AttendeeContext db = new AttendeeContext();

        //
        // GET: /Attendee/

        public ActionResult Index()
        {
            return View(db.Attendees.ToList());
        }

        //
        // GET: /Attendee/Details/5

        public ActionResult Details(int id = 0)
        {
            Attendee attendee = db.Attendees.Find(id);
            if (attendee == null)
            {
                return HttpNotFound();
            }
            return View(attendee);
        }

        //
        // GET: /Attendee/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Attendee/Create

        [HttpPost]
        public ActionResult Create(Attendee attendee)
        {
            if (ModelState.IsValid)
            {
                db.Attendees.Add(attendee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(attendee);
        }

        //
        // GET: /Attendee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Attendee attendee = db.Attendees.Find(id);
            if (attendee == null)
            {
                return HttpNotFound();
            }
            return View(attendee);
        }

        //
        // POST: /Attendee/Edit/5

        [HttpPost]
        public ActionResult Edit(Attendee attendee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(attendee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(attendee);
        }

        //
        // GET: /Attendee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Attendee attendee = db.Attendees.Find(id);
            if (attendee == null)
            {
                return HttpNotFound();
            }
            return View(attendee);
        }

        //
        // POST: /Attendee/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Attendee attendee = db.Attendees.Find(id);
            db.Attendees.Remove(attendee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}