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
    public class tlkpInactivesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpInactives
        public ActionResult Index()
        {
            return View(db.tlkpInactives.ToList());
        }

        // GET: tlkpInactives/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpInactive tlkpInactive = db.tlkpInactives.Find(id);
            if (tlkpInactive == null)
            {
                return HttpNotFound();
            }
            return View(tlkpInactive);
        }

        // GET: tlkpInactives/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpInactives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Description,Action,SSMA_TimeStamp")] tlkpInactive tlkpInactive)
        {
            if (ModelState.IsValid)
            {
                db.tlkpInactives.Add(tlkpInactive);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpInactive);
        }

        // GET: tlkpInactives/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpInactive tlkpInactive = db.tlkpInactives.Find(id);
            if (tlkpInactive == null)
            {
                return HttpNotFound();
            }
            return View(tlkpInactive);
        }

        // POST: tlkpInactives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Description,Action,SSMA_TimeStamp")] tlkpInactive tlkpInactive)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpInactive).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpInactive);
        }

        // GET: tlkpInactives/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpInactive tlkpInactive = db.tlkpInactives.Find(id);
            if (tlkpInactive == null)
            {
                return HttpNotFound();
            }
            return View(tlkpInactive);
        }

        // POST: tlkpInactives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpInactive tlkpInactive = db.tlkpInactives.Find(id);
            db.tlkpInactives.Remove(tlkpInactive);
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
