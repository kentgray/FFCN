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
    public class tlkpTrainAttendIntroesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpTrainAttendIntroes
        public ActionResult Index()
        {
            return View(db.tlkpTrainAttendIntroes.ToList());
        }

        // GET: tlkpTrainAttendIntroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainAttendIntro tlkpTrainAttendIntro = db.tlkpTrainAttendIntroes.Find(id);
            if (tlkpTrainAttendIntro == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainAttendIntro);
        }

        // GET: tlkpTrainAttendIntroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpTrainAttendIntroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TrainDate")] tlkpTrainAttendIntro tlkpTrainAttendIntro)
        {
            if (ModelState.IsValid)
            {
                db.tlkpTrainAttendIntroes.Add(tlkpTrainAttendIntro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpTrainAttendIntro);
        }

        // GET: tlkpTrainAttendIntroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainAttendIntro tlkpTrainAttendIntro = db.tlkpTrainAttendIntroes.Find(id);
            if (tlkpTrainAttendIntro == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainAttendIntro);
        }

        // POST: tlkpTrainAttendIntroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TrainDate")] tlkpTrainAttendIntro tlkpTrainAttendIntro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpTrainAttendIntro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpTrainAttendIntro);
        }

        // GET: tlkpTrainAttendIntroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpTrainAttendIntro tlkpTrainAttendIntro = db.tlkpTrainAttendIntroes.Find(id);
            if (tlkpTrainAttendIntro == null)
            {
                return HttpNotFound();
            }
            return View(tlkpTrainAttendIntro);
        }

        // POST: tlkpTrainAttendIntroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpTrainAttendIntro tlkpTrainAttendIntro = db.tlkpTrainAttendIntroes.Find(id);
            db.tlkpTrainAttendIntroes.Remove(tlkpTrainAttendIntro);
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
