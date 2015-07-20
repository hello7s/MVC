using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoubleR.Models;

namespace DoubleR.Controllers
{
    public class TuneRummiesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TuneRummies
        public ActionResult Index()
        {
            return View(db.TuneRummies.ToList());
        }

        // GET: TuneRummies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuneRummy tuneRummy = db.TuneRummies.Find(id);
            if (tuneRummy == null)
            {
                return HttpNotFound();
            }
            return View(tuneRummy);
        }

        // GET: TuneRummies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TuneRummies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TuneRummyId,ScreenName,Email")] TuneRummy tuneRummy)
        {
            if (ModelState.IsValid)
            {
                db.TuneRummies.Add(tuneRummy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tuneRummy);
        }

        // GET: TuneRummies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuneRummy tuneRummy = db.TuneRummies.Find(id);
            if (tuneRummy == null)
            {
                return HttpNotFound();
            }
            return View(tuneRummy);
        }

        // POST: TuneRummies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TuneRummyId,ScreenName,Email")] TuneRummy tuneRummy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tuneRummy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tuneRummy);
        }

        // GET: TuneRummies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TuneRummy tuneRummy = db.TuneRummies.Find(id);
            if (tuneRummy == null)
            {
                return HttpNotFound();
            }
            return View(tuneRummy);
        }

        // POST: TuneRummies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TuneRummy tuneRummy = db.TuneRummies.Find(id);
            db.TuneRummies.Remove(tuneRummy);
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
