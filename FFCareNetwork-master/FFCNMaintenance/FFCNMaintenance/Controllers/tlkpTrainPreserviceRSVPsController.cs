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
    public class tlkpTrainPreserviceRSVPsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpTrainPreserviceRSVPs
        public ActionResult Index()
        {
            return View(db.tlkpTrainPreserviceRSVPs.ToList());
        }

        // GET: tlkpTrainPreserviceRSVPs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreserviceRSVP tlkpTrainPreserviceRSVP = db.tlkpTrainPreserviceRSVPs.Find(id);
            if (tlkpTrainPreserviceRSVP == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreserviceRSVP);
        }

        // GET: tlkpTrainPreserviceRSVPs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpTrainPreserviceRSVPs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TrainDate")] tlkpTrainPreserviceRSVP tlkpTrainPreserviceRSVP)
        {
            if (ModelState.IsValid)
            {
                db.tlkpTrainPreserviceRSVPs.Add(tlkpTrainPreserviceRSVP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpTrainPreserviceRSVP);
        }

        // GET: tlkpTrainPreserviceRSVPs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreserviceRSVP tlkpTrainPreserviceRSVP = db.tlkpTrainPreserviceRSVPs.Find(id);
            if (tlkpTrainPreserviceRSVP == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreserviceRSVP);
        }

        // POST: tlkpTrainPreserviceRSVPs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TrainDate")] tlkpTrainPreserviceRSVP tlkpTrainPreserviceRSVP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpTrainPreserviceRSVP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpTrainPreserviceRSVP);
        }

        // GET: tlkpTrainPreserviceRSVPs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainPreserviceRSVP tlkpTrainPreserviceRSVP = db.tlkpTrainPreserviceRSVPs.Find(id);
            if (tlkpTrainPreserviceRSVP == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainPreserviceRSVP);
        }

        // POST: tlkpTrainPreserviceRSVPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpTrainPreserviceRSVP tlkpTrainPreserviceRSVP = db.tlkpTrainPreserviceRSVPs.Find(id);
            db.tlkpTrainPreserviceRSVPs.Remove(tlkpTrainPreserviceRSVP);
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
