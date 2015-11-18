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
    public class tlkpUserGroupsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpUserGroups
        public ActionResult Index()
        {
            return View(db.tlkpUserGroups.ToList());
        }

        // GET: tlkpUserGroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpUserGroup tlkpUserGroup = db.tlkpUserGroups.Find(id);
            if (tlkpUserGroup == null)
            {
                return HttpNotFound();
            }
            return View(tlkpUserGroup);
        }

        // GET: tlkpUserGroups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpUserGroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpUserGroup tlkpUserGroup)
        {
            if (ModelState.IsValid)
            {
                db.tlkpUserGroups.Add(tlkpUserGroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpUserGroup);
        }

        // GET: tlkpUserGroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpUserGroup tlkpUserGroup = db.tlkpUserGroups.Find(id);
            if (tlkpUserGroup == null)
            {
                return HttpNotFound();
            }
            return View(tlkpUserGroup);
        }

        // POST: tlkpUserGroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpUserGroup tlkpUserGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpUserGroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpUserGroup);
        }

        // GET: tlkpUserGroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpUserGroup tlkpUserGroup = db.tlkpUserGroups.Find(id);
            if (tlkpUserGroup == null)
            {
                return HttpNotFound();
            }
            return View(tlkpUserGroup);
        }

        // POST: tlkpUserGroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpUserGroup tlkpUserGroup = db.tlkpUserGroups.Find(id);
            db.tlkpUserGroups.Remove(tlkpUserGroup);
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
