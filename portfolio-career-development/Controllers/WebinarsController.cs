﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using portfolio_career_development.Models;

namespace portfolio_career_development.Controllers
{
    public class WebinarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Webinars
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.STAFF_USER))
            {
                return View("List");
            }
            return View("ReadonlyList");
        }

        // GET: Webinars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Webinar webinar = db.Webinars.Find(id);
            if (webinar == null)
            {
                return HttpNotFound();
            }
            return View(webinar);
        }

        // GET: Webinars/Create
        [Authorize(Roles = RoleName.STAFF_USER)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Webinars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.STAFF_USER)]
        public ActionResult Create([Bind(Include = "Id,Topic,About,CoursePrice,DateWebinar")] Webinar webinar)
        {
            if (ModelState.IsValid)
            {
                db.Webinars.Add(webinar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(webinar);
        }

        // GET: Webinars/Edit/5
        [Authorize(Roles = RoleName.STAFF_USER)]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Webinar webinar = db.Webinars.Find(id);
            if (webinar == null)
            {
                return HttpNotFound();
            }
            return View(webinar);
        }

        // POST: Webinars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.STAFF_USER)]
        public ActionResult Edit([Bind(Include = "Id,Topic,About,CoursePrice,DateWebinar")] Webinar webinar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(webinar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(webinar);
        }

        // GET: Webinars/Delete/5
        [Authorize(Roles = RoleName.STAFF_USER)]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Webinar webinar = db.Webinars.Find(id);
            if (webinar == null)
            {
                return HttpNotFound();
            }
            return View(webinar);
        }

        // POST: Webinars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.STAFF_USER)]
        public ActionResult DeleteConfirmed(int id)
        {
            Webinar webinar = db.Webinars.Find(id);
            db.Webinars.Remove(webinar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
