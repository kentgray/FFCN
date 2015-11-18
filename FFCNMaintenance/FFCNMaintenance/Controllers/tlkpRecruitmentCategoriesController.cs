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
    public class tlkpRecruitmentCategoriesController : Controller
    {
        private FFCNv5Entities db = new FFCNv5Entities();

        // GET: tlkpRecruitmentCategories
        public ActionResult Index()
        {
            return View(db.tlkpRecruitmentCategories.ToList());
        }

        // GET: tlkpRecruitmentCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpRecruitmentCategory tlkpRecruitmentCategory = db.tlkpRecruitmentCategories.Find(id);
            if (tlkpRecruitmentCategory == null)
            {
                return HttpNotFound();
            }
            return View(tlkpRecruitmentCategory);
        }

        // GET: tlkpRecruitmentCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tlkpRecruitmentCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpRecruitmentCategory tlkpRecruitmentCategory)
        {
            if (ModelState.IsValid)
            {
                db.tlkpRecruitmentCategories.Add(tlkpRecruitmentCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tlkpRecruitmentCategory);
        }

        // GET: tlkpRecruitmentCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpRecruitmentCategory tlkpRecruitmentCategory = db.tlkpRecruitmentCategories.Find(id);
            if (tlkpRecruitmentCategory == null)
            {
                return HttpNotFound();
            }
            return View(tlkpRecruitmentCategory);
        }

        // POST: tlkpRecruitmentCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Descr,Active,SSMA_TimeStamp")] tlkpRecruitmentCategory tlkpRecruitmentCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tlkpRecruitmentCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tlkpRecruitmentCategory);
        }

        // GET: tlkpRecruitmentCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tlkpRecruitmentCategory tlkpRecruitmentCategory = db.tlkpRecruitmentCategories.Find(id);
            if (tlkpRecruitmentCategory == null)
            {
                return HttpNotFound();
            }
            return View(tlkpRecruitmentCategory);
        }

        // POST: tlkpRecruitmentCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tlkpRecruitmentCategory tlkpRecruitmentCategory = db.tlkpRecruitmentCategories.Find(id);
            db.tlkpRecruitmentCategories.Remove(tlkpRecruitmentCategory);
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
