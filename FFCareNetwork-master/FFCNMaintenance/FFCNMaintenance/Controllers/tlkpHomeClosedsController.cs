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
    public class tlkpHomeClosedsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpHomeCloseds
        public ActionResult Index()
        {
            return View(db.tlkpHomeCloseds.ToList());
        }

        // GET: tlkpHomeCloseds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpHomeClosed tlkpHomeClosed = db.tlkpHomeCloseds.Find(id);
            if (tlkpHomeClosed == null)
            {
                return HttpNotFound();
            }
            return View(tlkpHomeClosed);
        }

        // GET: tlkpHomeCloseds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpHomeCloseds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Reason")] tlkpHomeClosed tlkpHomeClosed)
        {
            if (ModelState.IsValid)
            {
                db.tlkpHomeCloseds.Add(tlkpHomeClosed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpHomeClosed);
        }

        // GET: tlkpHomeCloseds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpHomeClosed tlkpHomeClosed = db.tlkpHomeCloseds.Find(id);
            if (tlkpHomeClosed == null)
            {
                return HttpNotFound();
            }
            return View(tlkpHomeClosed);
        }

        // POST: tlkpHomeCloseds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Reason")] tlkpHomeClosed tlkpHomeClosed)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpHomeClosed).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpHomeClosed);
        }

        // GET: tlkpHomeCloseds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpHomeClosed tlkpHomeClosed = db.tlkpHomeCloseds.Find(id);
            if (tlkpHomeClosed == null)
            {
                return HttpNotFound();
            }
            return View(tlkpHomeClosed);
        }

        // POST: tlkpHomeCloseds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpHomeClosed tlkpHomeClosed = db.tlkpHomeCloseds.Find(id);
            db.tlkpHomeCloseds.Remove(tlkpHomeClosed);
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
