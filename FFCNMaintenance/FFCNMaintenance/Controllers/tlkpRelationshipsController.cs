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
    public class tlkpRelationshipsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpRelationships
        public ActionResult Index()
        {
            return View(db.tlkpRelationships.ToList());
        }

        // GET: tlkpRelationships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpRelationship tlkpRelationship = db.tlkpRelationships.Find(id);
            if (tlkpRelationship == null)
            {
                return HttpNotFound();
            }
            return View(tlkpRelationship);
        }

        // GET: tlkpRelationships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpRelationships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpRelationship tlkpRelationship)
        {
            if (ModelState.IsValid)
            {
                db.tlkpRelationships.Add(tlkpRelationship);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpRelationship);
        }

        // GET: tlkpRelationships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpRelationship tlkpRelationship = db.tlkpRelationships.Find(id);
            if (tlkpRelationship == null)
            {
                return HttpNotFound();
            }
            return View(tlkpRelationship);
        }

        // POST: tlkpRelationships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpRelationship tlkpRelationship)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpRelationship).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpRelationship);
        }

        // GET: tlkpRelationships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpRelationship tlkpRelationship = db.tlkpRelationships.Find(id);
            if (tlkpRelationship == null)
            {
                return HttpNotFound();
            }
            return View(tlkpRelationship);
        }

        // POST: tlkpRelationships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpRelationship tlkpRelationship = db.tlkpRelationships.Find(id);
            db.tlkpRelationships.Remove(tlkpRelationship);
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
