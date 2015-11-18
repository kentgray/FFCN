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
    public class tlkpAgenciesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpAgencies
        public ActionResult Index()
        {
            return View(db.tlkpAgencies.ToList());
        }

        // GET: tlkpAgencies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAgency tlkpAgency = db.tlkpAgencies.Find(id);
            if (tlkpAgency == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAgency);
        }

        // GET: tlkpAgencies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpAgencies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpAgency tlkpAgency)
        {
            if (ModelState.IsValid)
            {
                db.tlkpAgencies.Add(tlkpAgency);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpAgency);
        }

        // GET: tlkpAgencies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAgency tlkpAgency = db.tlkpAgencies.Find(id);
            if (tlkpAgency == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAgency);
        }

        // POST: tlkpAgencies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpAgency tlkpAgency)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpAgency).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpAgency);
        }

        // GET: tlkpAgencies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAgency tlkpAgency = db.tlkpAgencies.Find(id);
            if (tlkpAgency == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAgency);
        }

        // POST: tlkpAgencies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpAgency tlkpAgency = db.tlkpAgencies.Find(id);
            db.tlkpAgencies.Remove(tlkpAgency);
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
