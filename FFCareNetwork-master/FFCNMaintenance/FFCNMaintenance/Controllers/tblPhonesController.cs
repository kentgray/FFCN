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
    public class tblPhonesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tblPhones
        public ActionResult Index(int id)
        {
            var phones = from p in db.tblPhones
                         where p.CareGiverID == id
                         select p;
            
            return View(phones.ToList());
        }

        // GET: tblPhones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPhone tblPhone = db.tblPhones.Find(id);
            if (tblPhone == null)
            {
                return HttpNotFound();
            }
            return View(tblPhone);
        }

        // GET: tblPhones/Create
        public ActionResult Create()
        {
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName");
            return View();
        }

        // POST: tblPhones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CareGiverID,Phone,PhoneType,Active,SSMA_TimeStamp")] tblPhone tblPhone)
        {
            if (ModelState.IsValid)
            {
                db.tblPhones.Add(tblPhone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblPhone.CareGiverID);
            return View(tblPhone);
        }

        // GET: tblPhones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPhone tblPhone = db.tblPhones.Find(id);
            if (tblPhone == null)
            {
                return HttpNotFound();
            }
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblPhone.CareGiverID);
            return View(tblPhone);
        }

        // POST: tblPhones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CareGiverID,Phone,PhoneType,Active,SSMA_TimeStamp")] tblPhone tblPhone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblPhone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblPhone.CareGiverID);
            return View(tblPhone);
        }

        // GET: tblPhones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPhone tblPhone = db.tblPhones.Find(id);
            if (tblPhone == null)
            {
                return HttpNotFound();
            }
            return View(tblPhone);
        }

        // POST: tblPhones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblPhone tblPhone = db.tblPhones.Find(id);
            db.tblPhones.Remove(tblPhone);
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
