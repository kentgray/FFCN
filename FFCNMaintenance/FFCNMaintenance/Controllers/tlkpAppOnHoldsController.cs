using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FFCNMaintenance.Models;

namespace FFCNMaintenance.Controllers
{
    public class tlkpAppOnHoldsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpAppOnHolds
        public ActionResult Index()
        {
            return View(db.tlkpAppOnHolds.ToList());
        }

        // GET: tlkpAppOnHolds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppOnHold tlkpAppOnHold = db.tlkpAppOnHolds.Find(id);
            if (tlkpAppOnHold == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppOnHold);
        }

        // GET: tlkpAppOnHolds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpAppOnHolds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Reason")] tlkpAppOnHold tlkpAppOnHold)
        {
            if (ModelState.IsValid)
            {
                db.tlkpAppOnHolds.Add(tlkpAppOnHold);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpAppOnHold);
        }

        // GET: tlkpAppOnHolds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppOnHold tlkpAppOnHold = db.tlkpAppOnHolds.Find(id);
            if (tlkpAppOnHold == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppOnHold);
        }

        // POST: tlkpAppOnHolds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Reason")] tlkpAppOnHold tlkpAppOnHold)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpAppOnHold).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpAppOnHold);
        }

        // GET: tlkpAppOnHolds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppOnHold tlkpAppOnHold = db.tlkpAppOnHolds.Find(id);
            if (tlkpAppOnHold == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppOnHold);
        }

        // POST: tlkpAppOnHolds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpAppOnHold tlkpAppOnHold = db.tlkpAppOnHolds.Find(id);
            db.tlkpAppOnHolds.Remove(tlkpAppOnHold);
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
