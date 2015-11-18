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
    public class tblEmailsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tblEmails
        public ActionResult Index(int id)
        {
            var emails = from e in db.tblEmails
                         where e.CareGiverID == id
                         select e;

            return View(emails.ToList());
        }

        // GET: tblEmails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmail tblEmail = db.tblEmails.Find(id);
            if (tblEmail == null)
            {
                return HttpNotFound();
            }
            return View(tblEmail);
        }

        // GET: tblEmails/Create
        public ActionResult Create()
        {
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName");
            return View();
        }

        // POST: tblEmails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CareGiverID,EMail,EmailType")] tblEmail tblEmail)
        {
            if (ModelState.IsValid)
            {
                db.tblEmails.Add(tblEmail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblEmail.CareGiverID);
            return View(tblEmail);
        }

        // GET: tblEmails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmail tblEmail = db.tblEmails.Find(id);
            if (tblEmail == null)
            {
                return HttpNotFound();
            }
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblEmail.CareGiverID);
            return View(tblEmail);
        }

        // POST: tblEmails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CareGiverID,EMail,EmailType")] tblEmail tblEmail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblEmail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblEmail.CareGiverID);
            return View(tblEmail);
        }

        // GET: tblEmails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmail tblEmail = db.tblEmails.Find(id);
            if (tblEmail == null)
            {
                return HttpNotFound();
            }
            return View(tblEmail);
        }

        // POST: tblEmails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblEmail tblEmail = db.tblEmails.Find(id);
            db.tblEmails.Remove(tblEmail);
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
