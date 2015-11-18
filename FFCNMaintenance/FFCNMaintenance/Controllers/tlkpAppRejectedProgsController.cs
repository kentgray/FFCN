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
    public class tlkpAppRejectedProgsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpAppRejectedProgs
        public ActionResult Index()
        {
            return View(db.tlkpAppRejectedProgs.ToList());
        }

        // GET: tlkpAppRejectedProgs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppRejectedProg tlkpAppRejectedProg = db.tlkpAppRejectedProgs.Find(id);
            if (tlkpAppRejectedProg == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppRejectedProg);
        }

        // GET: tlkpAppRejectedProgs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpAppRejectedProgs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Reason")] tlkpAppRejectedProg tlkpAppRejectedProg)
        {
            if (ModelState.IsValid)
            {
                db.tlkpAppRejectedProgs.Add(tlkpAppRejectedProg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpAppRejectedProg);
        }

        // GET: tlkpAppRejectedProgs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppRejectedProg tlkpAppRejectedProg = db.tlkpAppRejectedProgs.Find(id);
            if (tlkpAppRejectedProg == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppRejectedProg);
        }

        // POST: tlkpAppRejectedProgs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Reason")] tlkpAppRejectedProg tlkpAppRejectedProg)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpAppRejectedProg).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpAppRejectedProg);
        }

        // GET: tlkpAppRejectedProgs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppRejectedProg tlkpAppRejectedProg = db.tlkpAppRejectedProgs.Find(id);
            if (tlkpAppRejectedProg == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppRejectedProg);
        }

        // POST: tlkpAppRejectedProgs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpAppRejectedProg tlkpAppRejectedProg = db.tlkpAppRejectedProgs.Find(id);
            db.tlkpAppRejectedProgs.Remove(tlkpAppRejectedProg);
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
