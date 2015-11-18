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
    public class tlkpOngoingTrainingsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpOngoingTrainings
        public ActionResult Index()
        {
            return View(db.tlkpOngoingTrainings.ToList());
        }

        // GET: tlkpOngoingTrainings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpOngoingTraining tlkpOngoingTraining = db.tlkpOngoingTrainings.Find(id);
            if (tlkpOngoingTraining == null)
            {
                return HttpNotFound();
            }
            return View(tlkpOngoingTraining);
        }

        // GET: tlkpOngoingTrainings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpOngoingTrainings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpOngoingTraining tlkpOngoingTraining)
        {
            if (ModelState.IsValid)
            {
                db.tlkpOngoingTrainings.Add(tlkpOngoingTraining);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpOngoingTraining);
        }

        // GET: tlkpOngoingTrainings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpOngoingTraining tlkpOngoingTraining = db.tlkpOngoingTrainings.Find(id);
            if (tlkpOngoingTraining == null)
            {
                return HttpNotFound();
            }
            return View(tlkpOngoingTraining);
        }

        // POST: tlkpOngoingTrainings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpOngoingTraining tlkpOngoingTraining)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpOngoingTraining).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpOngoingTraining);
        }

        // GET: tlkpOngoingTrainings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpOngoingTraining tlkpOngoingTraining = db.tlkpOngoingTrainings.Find(id);
            if (tlkpOngoingTraining == null)
            {
                return HttpNotFound();
            }
            return View(tlkpOngoingTraining);
        }

        // POST: tlkpOngoingTrainings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpOngoingTraining tlkpOngoingTraining = db.tlkpOngoingTrainings.Find(id);
            db.tlkpOngoingTrainings.Remove(tlkpOngoingTraining);
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
