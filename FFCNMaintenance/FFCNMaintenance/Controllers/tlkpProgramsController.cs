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
    public class tlkpProgramsController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpPrograms
        public ActionResult Index()
        {
            return View(db.tlkpPrograms.ToList());
        }

        // GET: tlkpPrograms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpProgram tlkpProgram = db.tlkpPrograms.Find(id);
            if (tlkpProgram == null)
            {
                return HttpNotFound();
            }
            return View(tlkpProgram);
        }

        // GET: tlkpPrograms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpPrograms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Description,Active,SSMA_TimeStamp")] tlkpProgram tlkpProgram)
        {
            if (ModelState.IsValid)
            {
                db.tlkpPrograms.Add(tlkpProgram);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpProgram);
        }

        // GET: tlkpPrograms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpProgram tlkpProgram = db.tlkpPrograms.Find(id);
            if (tlkpProgram == null)
            {
                return HttpNotFound();
            }
            return View(tlkpProgram);
        }

        // POST: tlkpPrograms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Description,Active,SSMA_TimeStamp")] tlkpProgram tlkpProgram)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpProgram).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpProgram);
        }

        // GET: tlkpPrograms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpProgram tlkpProgram = db.tlkpPrograms.Find(id);
            if (tlkpProgram == null)
            {
                return HttpNotFound();
            }
            return View(tlkpProgram);
        }

        // POST: tlkpPrograms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpProgram tlkpProgram = db.tlkpPrograms.Find(id);
            db.tlkpPrograms.Remove(tlkpProgram);
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
