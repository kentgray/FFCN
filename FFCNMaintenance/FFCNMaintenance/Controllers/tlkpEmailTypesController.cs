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
    public class tlkpEmailTypesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpEmailTypes
        public ActionResult Index()
        {
            return View(db.tlkpEmailTypes.ToList());
        }

        // GET: tlkpEmailTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpEmailType tlkpEmailType = db.tlkpEmailTypes.Find(id);
            if (tlkpEmailType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpEmailType);
        }

        // GET: tlkpEmailTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpEmailTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Descr,Active")] tlkpEmailType tlkpEmailType)
        {
            if (ModelState.IsValid)
            {
                db.tlkpEmailTypes.Add(tlkpEmailType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpEmailType);
        }

        // GET: tlkpEmailTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpEmailType tlkpEmailType = db.tlkpEmailTypes.Find(id);
            if (tlkpEmailType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpEmailType);
        }

        // POST: tlkpEmailTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Descr,Active")] tlkpEmailType tlkpEmailType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpEmailType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpEmailType);
        }

        // GET: tlkpEmailTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpEmailType tlkpEmailType = db.tlkpEmailTypes.Find(id);
            if (tlkpEmailType == null)
            {
                return HttpNotFound();
            }
            return View(tlkpEmailType);
        }

        // POST: tlkpEmailTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpEmailType tlkpEmailType = db.tlkpEmailTypes.Find(id);
            db.tlkpEmailTypes.Remove(tlkpEmailType);
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
