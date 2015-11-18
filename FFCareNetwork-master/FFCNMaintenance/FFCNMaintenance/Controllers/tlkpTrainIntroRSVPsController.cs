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
    public class tlkpTrainIntroRSVPsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpTrainIntroRSVPs
        public ActionResult Index()
        {
            return View(db.tlkpTrainIntroRSVPs.ToList());
        }

        // GET: tlkpTrainIntroRSVPs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainIntroRSVP tlkpTrainIntroRSVP = db.tlkpTrainIntroRSVPs.Find(id);
            if (tlkpTrainIntroRSVP == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainIntroRSVP);
        }

        // GET: tlkpTrainIntroRSVPs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpTrainIntroRSVPs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TrainDate")] tlkpTrainIntroRSVP tlkpTrainIntroRSVP)
        {
            if (ModelState.IsValid)
            {
                db.tlkpTrainIntroRSVPs.Add(tlkpTrainIntroRSVP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpTrainIntroRSVP);
        }

        // GET: tlkpTrainIntroRSVPs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainIntroRSVP tlkpTrainIntroRSVP = db.tlkpTrainIntroRSVPs.Find(id);
            if (tlkpTrainIntroRSVP == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainIntroRSVP);
        }

        // POST: tlkpTrainIntroRSVPs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TrainDate")] tlkpTrainIntroRSVP tlkpTrainIntroRSVP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpTrainIntroRSVP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpTrainIntroRSVP);
        }

        // GET: tlkpTrainIntroRSVPs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainIntroRSVP tlkpTrainIntroRSVP = db.tlkpTrainIntroRSVPs.Find(id);
            if (tlkpTrainIntroRSVP == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainIntroRSVP);
        }

        // POST: tlkpTrainIntroRSVPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpTrainIntroRSVP tlkpTrainIntroRSVP = db.tlkpTrainIntroRSVPs.Find(id);
            db.tlkpTrainIntroRSVPs.Remove(tlkpTrainIntroRSVP);
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
