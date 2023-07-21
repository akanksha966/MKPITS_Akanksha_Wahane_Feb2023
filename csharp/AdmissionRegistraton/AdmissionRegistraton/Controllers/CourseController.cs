using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdmissionRegistraton.Models;

namespace AdmissionRegistraton.Controllers
{
    public class CourseController : Controller
    {
        private CourseModel db = new CourseModel();

        // GET: Course
        public ActionResult Index()
        {
            return View(db.Coursetables.ToList());
        }

        // GET: Course/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coursetable coursetable = db.Coursetables.Find(id);
            if (coursetable == null)
            {
                return HttpNotFound();
            }
            return View(coursetable);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseId,CourseName,Duration")] Coursetable coursetable)
        {
            if (ModelState.IsValid)
            {
                db.Coursetables.Add(coursetable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coursetable);
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coursetable coursetable = db.Coursetables.Find(id);
            if (coursetable == null)
            {
                return HttpNotFound();
            }
            return View(coursetable);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseId,CourseName,Duration")] Coursetable coursetable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coursetable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coursetable);
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coursetable coursetable = db.Coursetables.Find(id);
            if (coursetable == null)
            {
                return HttpNotFound();
            }
            return View(coursetable);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Coursetable coursetable = db.Coursetables.Find(id);
            db.Coursetables.Remove(coursetable);
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
