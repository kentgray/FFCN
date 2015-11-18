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
    public class tlkpAddressTypesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpAddressTypes
        public ActionResult Index()
        {
            return View(db.tlkpAddressTypes.ToList());
        }

        // GET: tlkpAddressTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAddressType tlkpAddressType = db.tlkpAddressTypes.Find(id);
            if (tlkpAddressType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAddressType);
        }

        // GET: tlkpAddressTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpAddressTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpAddressType tlkpAddressType)
        {
            if (ModelState.IsValid)
            {
                db.tlkpAddressTypes.Add(tlkpAddressType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpAddressType);
        }

        // GET: tlkpAddressTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAddressType tlkpAddressType = db.tlkpAddressTypes.Find(id);
            if (tlkpAddressType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAddressType);
        }

        // POST: tlkpAddressTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpAddressType tlkpAddressType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpAddressType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpAddressType);
        }

        // GET: tlkpAddressTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAddressType tlkpAddressType = db.tlkpAddressTypes.Find(id);
            if (tlkpAddressType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAddressType);
        }

        // POST: tlkpAddressTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpAddressType tlkpAddressType = db.tlkpAddressTypes.Find(id);
            db.tlkpAddressTypes.Remove(tlkpAddressType);
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
