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
    public class tlkpTrainPreservice2009Controller : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpTrainPreservice2009
        public ActionResult Index()
        {
            return View(db.tlkpTrainPreservice2009.ToList());
        }

        // GET: tlkpTrainPreservice2009/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice2009 tlkpTrainPreservice2009 = db.tlkpTrainPreservice2009.Find(id);
            if (tlkpTrainPreservice2009 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice2009);
        }

        // GET: tlkpTrainPreservice2009/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpTrainPreservice2009/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TrainDate")] tlkpTrainPreservice2009 tlkpTrainPreservice2009)
        {
            if (ModelState.IsValid)
            {
                db.tlkpTrainPreservice2009.Add(tlkpTrainPreservice2009);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpTrainPreservice2009);
        }

        // GET: tlkpTrainPreservice2009/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice2009 tlkpTrainPreservice2009 = db.tlkpTrainPreservice2009.Find(id);
            if (tlkpTrainPreservice2009 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice2009);
        }

        // POST: tlkpTrainPreservice2009/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TrainDate")] tlkpTrainPreservice2009 tlkpTrainPreservice2009)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpTrainPreservice2009).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpTrainPreservice2009);
        }

        // GET: tlkpTrainPreservice2009/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreservice2009 tlkpTrainPreservice2009 = db.tlkpTrainPreservice2009.Find(id);
            if (tlkpTrainPreservice2009 == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreservice2009);
        }

        // POST: tlkpTrainPreservice2009/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpTrainPreservice2009 tlkpTrainPreservice2009 = db.tlkpTrainPreservice2009.Find(id);
            db.tlkpTrainPreservice2009.Remove(tlkpTrainPreservice2009);
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
