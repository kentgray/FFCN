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
    public class tblAddressesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tblAddresses
        public ActionResult Index(int id)
        {
            var addresses = from a in db.tblAddresses
                            where a.CareGiverID == id
                            select a;


            return View(addresses.ToList());
        }

        // GET: tblAddresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAddress tblAddress = db.tblAddresses.Find(id);
            if (tblAddress == null)
            {
                return HttpNotFound();
            }
            return View(tblAddress);
        }

        // GET: tblAddresses/Create
        public ActionResult Create()
        {
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName");
            return View();
        }

        // POST: tblAddresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CareGiverID,Street1,Street2,City,State,Zip,AddressType,Active,SSMA_TimeStamp")] tblAddress tblAddress)
        {
            if (ModelState.IsValid)
            {
                db.tblAddresses.Add(tblAddress);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblAddress.CareGiverID);
            return View(tblAddress);
        }

        // GET: tblAddresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAddress tblAddress = db.tblAddresses.Find(id);
            if (tblAddress == null)
            {
                return HttpNotFound();
            }
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblAddress.CareGiverID);
            return View(tblAddress);
        }

        // POST: tblAddresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CareGiverID,Street1,Street2,City,State,Zip,AddressType,Active,SSMA_TimeStamp")] tblAddress tblAddress)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblAddress).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CareGiverID = new SelectList(db.tblPrimaryCaregiverdatas, "CareGiverID", "FirstName", tblAddress.CareGiverID);
            return View(tblAddress);
        }

        // GET: tblAddresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblAddress tblAddress = db.tblAddresses.Find(id);
            if (tblAddress == null)
            {
                return HttpNotFound();
            }
            return View(tblAddress);
        }

        // POST: tblAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblAddress tblAddress = db.tblAddresses.Find(id);
            db.tblAddresses.Remove(tblAddress);
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
