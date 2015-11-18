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
    public class tlkpTrainPreserviceCompsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpTrainPreserviceComps
        public ActionResult Index()
        {
            return View(db.tlkpTrainPreserviceComps.ToList());
        }

        // GET: tlkpTrainPreserviceComps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreserviceComp tlkpTrainPreserviceComp = db.tlkpTrainPreserviceComps.Find(id);
            if (tlkpTrainPreserviceComp == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreserviceComp);
        }

        // GET: tlkpTrainPreserviceComps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpTrainPreserviceComps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TrainDate")] tlkpTrainPreserviceComp tlkpTrainPreserviceComp)
        {
            if (ModelState.IsValid)
            {
                db.tlkpTrainPreserviceComps.Add(tlkpTrainPreserviceComp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpTrainPreserviceComp);
        }

        // GET: tlkpTrainPreserviceComps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreserviceComp tlkpTrainPreserviceComp = db.tlkpTrainPreserviceComps.Find(id);
            if (tlkpTrainPreserviceComp == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreserviceComp);
        }

        // POST: tlkpTrainPreserviceComps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TrainDate")] tlkpTrainPreserviceComp tlkpTrainPreserviceComp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpTrainPreserviceComp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpTrainPreserviceComp);
        }

        // GET: tlkpTrainPreserviceComps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreserviceComp tlkpTrainPreserviceComp = db.tlkpTrainPreserviceComps.Find(id);
            if (tlkpTrainPreserviceComp == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreserviceComp);
        }

        // POST: tlkpTrainPreserviceComps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpTrainPreserviceComp tlkpTrainPreserviceComp = db.tlkpTrainPreserviceComps.Find(id);
            db.tlkpTrainPreserviceComps.Remove(tlkpTrainPreserviceComp);
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
