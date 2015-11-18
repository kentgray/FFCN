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
    public class tlkpAppReturnedsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpAppReturneds
        public ActionResult Index()
        {
            return View(db.tlkpAppReturneds.ToList());
        }

        // GET: tlkpAppReturneds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppReturned tlkpAppReturned = db.tlkpAppReturneds.Find(id);
            if (tlkpAppReturned == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppReturned);
        }

        // GET: tlkpAppReturneds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpAppReturneds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Reason")] tlkpAppReturned tlkpAppReturned)
        {
            if (ModelState.IsValid)
            {
                db.tlkpAppReturneds.Add(tlkpAppReturned);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpAppReturned);
        }

        // GET: tlkpAppReturneds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppReturned tlkpAppReturned = db.tlkpAppReturneds.Find(id);
            if (tlkpAppReturned == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppReturned);
        }

        // POST: tlkpAppReturneds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Reason")] tlkpAppReturned tlkpAppReturned)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpAppReturned).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpAppReturned);
        }

        // GET: tlkpAppReturneds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppReturned tlkpAppReturned = db.tlkpAppReturneds.Find(id);
            if (tlkpAppReturned == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppReturned);
        }

        // POST: tlkpAppReturneds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpAppReturned tlkpAppReturned = db.tlkpAppReturneds.Find(id);
            db.tlkpAppReturneds.Remove(tlkpAppReturned);
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
