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
    public class tlkpCommunicationTypesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpCommunicationTypes
        public ActionResult Index()
        {
            return View(db.tlkpCommunicationTypes.ToList());
        }

        // GET: tlkpCommunicationTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpCommunicationType tlkpCommunicationType = db.tlkpCommunicationTypes.Find(id);
            if (tlkpCommunicationType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpCommunicationType);
        }

        // GET: tlkpCommunicationTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpCommunicationTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpCommunicationType tlkpCommunicationType)
        {
            if (ModelState.IsValid)
            {
                db.tlkpCommunicationTypes.Add(tlkpCommunicationType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpCommunicationType);
        }

        // GET: tlkpCommunicationTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpCommunicationType tlkpCommunicationType = db.tlkpCommunicationTypes.Find(id);
            if (tlkpCommunicationType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpCommunicationType);
        }

        // POST: tlkpCommunicationTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpCommunicationType tlkpCommunicationType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpCommunicationType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpCommunicationType);
        }

        // GET: tlkpCommunicationTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpCommunicationType tlkpCommunicationType = db.tlkpCommunicationTypes.Find(id);
            if (tlkpCommunicationType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpCommunicationType);
        }

        // POST: tlkpCommunicationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpCommunicationType tlkpCommunicationType = db.tlkpCommunicationTypes.Find(id);
            db.tlkpCommunicationTypes.Remove(tlkpCommunicationType);
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
