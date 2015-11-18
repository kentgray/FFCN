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
    public class tlkpTrainPreservice1Controller : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpTrainPreservice1
        public ActionResult Index()
        {
            return View(db.tlkpTrainPreservice1.ToList());
        }

        // GET: tlkpTrainPreservice1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice1 tlkpTrainPreservice1 = db.tlkpTrainPreservice1.Find(id);
            if (tlkpTrainPreservice1 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice1);
        }

        // GET: tlkpTrainPreservice1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpTrainPreservice1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TrainDate")] tlkpTrainPreservice1 tlkpTrainPreservice1)
        {
            if (ModelState.IsValid)
            {
                db.tlkpTrainPreservice1.Add(tlkpTrainPreservice1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpTrainPreservice1);
        }

        // GET: tlkpTrainPreservice1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice1 tlkpTrainPreservice1 = db.tlkpTrainPreservice1.Find(id);
            if (tlkpTrainPreservice1 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice1);
        }

        // POST: tlkpTrainPreservice1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TrainDate")] tlkpTrainPreservice1 tlkpTrainPreservice1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpTrainPreservice1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpTrainPreservice1);
        }

        // GET: tlkpTrainPreservice1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice1 tlkpTrainPreservice1 = db.tlkpTrainPreservice1.Find(id);
            if (tlkpTrainPreservice1 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice1);
        }

        // POST: tlkpTrainPreservice1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpTrainPreservice1 tlkpTrainPreservice1 = db.tlkpTrainPreservice1.Find(id);
            db.tlkpTrainPreservice1.Remove(tlkpTrainPreservice1);
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
