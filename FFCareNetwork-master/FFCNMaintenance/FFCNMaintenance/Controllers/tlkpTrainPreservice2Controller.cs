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
    public class tlkpTrainPreservice2Controller : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpTrainPreservice2
        public ActionResult Index()
        {
            return View(db.tlkpTrainPreservice2.ToList());
        }

        // GET: tlkpTrainPreservice2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice2 tlkpTrainPreservice2 = db.tlkpTrainPreservice2.Find(id);
            if (tlkpTrainPreservice2 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice2);
        }

        // GET: tlkpTrainPreservice2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpTrainPreservice2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TrainDate")] tlkpTrainPreservice2 tlkpTrainPreservice2)
        {
            if (ModelState.IsValid)
            {
                db.tlkpTrainPreservice2.Add(tlkpTrainPreservice2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpTrainPreservice2);
        }

        // GET: tlkpTrainPreservice2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice2 tlkpTrainPreservice2 = db.tlkpTrainPreservice2.Find(id);
            if (tlkpTrainPreservice2 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice2);
        }

        // POST: tlkpTrainPreservice2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TrainDate")] tlkpTrainPreservice2 tlkpTrainPreservice2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpTrainPreservice2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpTrainPreservice2);
        }

        // GET: tlkpTrainPreservice2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice2 tlkpTrainPreservice2 = db.tlkpTrainPreservice2.Find(id);
            if (tlkpTrainPreservice2 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice2);
        }

        // POST: tlkpTrainPreservice2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpTrainPreservice2 tlkpTrainPreservice2 = db.tlkpTrainPreservice2.Find(id);
            db.tlkpTrainPreservice2.Remove(tlkpTrainPreservice2);
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
