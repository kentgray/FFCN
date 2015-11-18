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
    public class tlkpPhoneTypesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpPhoneTypes
        public ActionResult Index()
        {
            return View(db.tlkpPhoneTypes.ToList());
        }

        // GET: tlkpPhoneTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpPhoneType tlkpPhoneType = db.tlkpPhoneTypes.Find(id);
            if (tlkpPhoneType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpPhoneType);
        }

        // GET: tlkpPhoneTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpPhoneTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpPhoneType tlkpPhoneType)
        {
            if (ModelState.IsValid)
            {
                db.tlkpPhoneTypes.Add(tlkpPhoneType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpPhoneType);
        }

        // GET: tlkpPhoneTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpPhoneType tlkpPhoneType = db.tlkpPhoneTypes.Find(id);
            if (tlkpPhoneType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpPhoneType);
        }

        // POST: tlkpPhoneTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpPhoneType tlkpPhoneType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpPhoneType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpPhoneType);
        }

        // GET: tlkpPhoneTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpPhoneType tlkpPhoneType = db.tlkpPhoneTypes.Find(id);
            if (tlkpPhoneType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpPhoneType);
        }

        // POST: tlkpPhoneTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpPhoneType tlkpPhoneType = db.tlkpPhoneTypes.Find(id);
            db.tlkpPhoneTypes.Remove(tlkpPhoneType);
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
