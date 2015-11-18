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
    public class tlkpAppRejectedFFCNsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpAppRejectedFFCNs
        public ActionResult Index()
        {
            return View(db.tlkpAppRejectedFFCNs.ToList());
        }

        // GET: tlkpAppRejectedFFCNs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppRejectedFFCN tlkpAppRejectedFFCN = db.tlkpAppRejectedFFCNs.Find(id);
            if (tlkpAppRejectedFFCN == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppRejectedFFCN);
        }

        // GET: tlkpAppRejectedFFCNs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpAppRejectedFFCNs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Reason")] tlkpAppRejectedFFCN tlkpAppRejectedFFCN)
        {
            if (ModelState.IsValid)
            {
                db.tlkpAppRejectedFFCNs.Add(tlkpAppRejectedFFCN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpAppRejectedFFCN);
        }

        // GET: tlkpAppRejectedFFCNs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppRejectedFFCN tlkpAppRejectedFFCN = db.tlkpAppRejectedFFCNs.Find(id);
            if (tlkpAppRejectedFFCN == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppRejectedFFCN);
        }

        // POST: tlkpAppRejectedFFCNs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Reason")] tlkpAppRejectedFFCN tlkpAppRejectedFFCN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpAppRejectedFFCN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpAppRejectedFFCN);
        }

        // GET: tlkpAppRejectedFFCNs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpAppRejectedFFCN tlkpAppRejectedFFCN = db.tlkpAppRejectedFFCNs.Find(id);
            if (tlkpAppRejectedFFCN == null)
            {
                return HttpNotFound();
            }
            return View(tlkpAppRejectedFFCN);
        }

        // POST: tlkpAppRejectedFFCNs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpAppRejectedFFCN tlkpAppRejectedFFCN = db.tlkpAppRejectedFFCNs.Find(id);
            db.tlkpAppRejectedFFCNs.Remove(tlkpAppRejectedFFCN);
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
