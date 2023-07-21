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
    public class RegistrationController : Controller
    {
        private CourseModel db = new CourseModel();

        // GET: Registration
        public ActionResult Index()
        {
            var registrationTables = db.RegistrationTables.Include(r => r.BatchTable).Include(r => r.Coursetable);
            return View(registrationTables.ToList());
        }

        // GET: Registration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationTable registrationTable = db.RegistrationTables.Find(id);
            if (registrationTable == null)
            {
                return HttpNotFound();
            }
            return View(registrationTable);
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            ViewBag.batchId = new SelectList(db.BatchTables, "BatchId", "Batch");
            ViewBag.CourseId = new SelectList(db.Coursetables, "CourseId", "CourseName");
            return View();
        }

        // POST: Registration/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Nic,CourseId,batchId,Phoneno")] RegistrationTable registrationTable)
        {
            if (ModelState.IsValid)
            {
                db.RegistrationTables.Add(registrationTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.batchId = new SelectList(db.BatchTables, "BatchId", "Batch", registrationTable.batchId);
            ViewBag.CourseId = new SelectList(db.Coursetables, "CourseId", "CourseName", registrationTable.CourseId);
            return View(registrationTable);
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationTable registrationTable = db.RegistrationTables.Find(id);
            if (registrationTable == null)
            {
                return HttpNotFound();
            }
            ViewBag.batchId = new SelectList(db.BatchTables, "BatchId", "Batch", registrationTable.batchId);
            ViewBag.CourseId = new SelectList(db.Coursetables, "CourseId", "CourseName", registrationTable.CourseId);
            return View(registrationTable);
        }

        // POST: Registration/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Nic,CourseId,batchId,Phoneno")] RegistrationTable registrationTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registrationTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.batchId = new SelectList(db.BatchTables, "BatchId", "Batch", registrationTable.batchId);
            ViewBag.CourseId = new SelectList(db.Coursetables, "CourseId", "CourseName", registrationTable.CourseId);
            return View(registrationTable);
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationTable registrationTable = db.RegistrationTables.Find(id);
            if (registrationTable == null)
            {
                return HttpNotFound();
            }
            return View(registrationTable);
        }

        // POST: Registration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistrationTable registrationTable = db.RegistrationTables.Find(id);
            db.RegistrationTables.Remove(registrationTable);
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
