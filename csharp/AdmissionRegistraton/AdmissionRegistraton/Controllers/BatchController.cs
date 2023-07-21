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
    public class BatchController : Controller
    {
        private CourseModel db = new CourseModel();

        // GET: Batch
        public ActionResult Index()
        {
            return View(db.BatchTables.ToList());
        }

        // GET: Batch/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchTable batchTable = db.BatchTables.Find(id);
            if (batchTable == null)
            {
                return HttpNotFound();
            }
            return View(batchTable);
        }

        // GET: Batch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Batch/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BatchId,Batch,Year")] BatchTable batchTable)
        {
            if (ModelState.IsValid)
            {
                db.BatchTables.Add(batchTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(batchTable);
        }

        // GET: Batch/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchTable batchTable = db.BatchTables.Find(id);
            if (batchTable == null)
            {
                return HttpNotFound();
            }
            return View(batchTable);
        }

        // POST: Batch/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BatchId,Batch,Year")] BatchTable batchTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(batchTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(batchTable);
        }

        // GET: Batch/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BatchTable batchTable = db.BatchTables.Find(id);
            if (batchTable == null)
            {
                return HttpNotFound();
            }
            return View(batchTable);
        }

        // POST: Batch/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BatchTable batchTable = db.BatchTables.Find(id);
            db.BatchTables.Remove(batchTable);
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
