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
    public class tblPrimaryCaregiverdatasController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tblPrimaryCaregiverdatas
        public ActionResult Index(int id)
        {
            var primary = from p in db.tblPrimaryCaregiverdatas
                          where p.CareGiverID == id
                          select p;

            
            return View(primary.ToList());
        }

        // GET: tblPrimaryCaregiverdatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPrimaryCaregiverdata tblPrimaryCaregiverdata = db.tblPrimaryCaregiverdatas.Find(id);
            if (tblPrimaryCaregiverdata == null)
            {
                return HttpNotFound();
            }
            return View(tblPrimaryCaregiverdata);
        }

        // GET: tblPrimaryCaregiverdatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblPrimaryCaregiverdatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CareGiverID,FirstName,LastName,BestReached,DOB,Status,Gender,Certifier,Agency,Neighborhood,Notes,CreateDate,CreateBy,LastUpdate,UpdateBy,PhysicianRel,English,InternetAccess,LivesNear,Recovery,DHSRelease,ExtraRoom,Income,Over25,Roommate,DUI,Transportation,ParentChild,ChildrenHome,HeardAbout,Spanish,Respite,ChildrenInHome,Volunteer,Donor,SSMA_TimeStamp")] tblPrimaryCaregiverdata tblPrimaryCaregiverdata)
        {
            if (ModelState.IsValid)
            {
                db.tblPrimaryCaregiverdatas.Add(tblPrimaryCaregiverdata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblPrimaryCaregiverdata);
        }

        // GET: tblPrimaryCaregiverdatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPrimaryCaregiverdata tblPrimaryCaregiverdata = db.tblPrimaryCaregiverdatas.Find(id);
            if (tblPrimaryCaregiverdata == null)
            {
                return HttpNotFound();
            }
            return View(tblPrimaryCaregiverdata);
        }

        // POST: tblPrimaryCaregiverdatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CareGiverID,FirstName,LastName,BestReached,DOB,Status,Gender,Certifier,Agency,Neighborhood,Notes,CreateDate,CreateBy,LastUpdate,UpdateBy,PhysicianRel,English,InternetAccess,LivesNear,Recovery,DHSRelease,ExtraRoom,Income,Over25,Roommate,DUI,Transportation,ParentChild,ChildrenHome,HeardAbout,Spanish,Respite,ChildrenInHome,Volunteer,Donor,SSMA_TimeStamp")] tblPrimaryCaregiverdata tblPrimaryCaregiverdata)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblPrimaryCaregiverdata).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblPrimaryCaregiverdata);
        }

        // GET: tblPrimaryCaregiverdatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPrimaryCaregiverdata tblPrimaryCaregiverdata = db.tblPrimaryCaregiverdatas.Find(id);
            if (tblPrimaryCaregiverdata == null)
            {
                return HttpNotFound();
            }
            return View(tblPrimaryCaregiverdata);
        }

        // POST: tblPrimaryCaregiverdatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblPrimaryCaregiverdata tblPrimaryCaregiverdata = db.tblPrimaryCaregiverdatas.Find(id);
            db.tblPrimaryCaregiverdatas.Remove(tblPrimaryCaregiverdata);
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
