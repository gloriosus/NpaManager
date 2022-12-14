using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NpaManagerMVC.Models;

namespace NpaManagerMVC.Controllers {
   public class PeriodsController:Controller {
      private NpaDbContext db = new NpaDbContext();

      // GET: Periods
      public ActionResult Index() {
         var periods = db.Periods.OrderBy(i => i.DateFirst);
         return View(periods.ToList());
      }

      // GET: Periods/Details/5
      public ActionResult Details(string id) {
         if(id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         Period period = db.Periods.Find(id);
         if(period == null) {
            return HttpNotFound();
         }
         return View(period);
      }

      // GET: Periods/Create
      public ActionResult Create() {
         return View();
      }

      // POST: Periods/Create
      // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
      // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create([Bind(Include = "PeriodId,Year,Quaretr,DateFirst,DateEnd,Editable,Browsable")] Period period) {
         if(ModelState.IsValid) {
            db.Periods.Add(period);
            db.SaveChanges();
            return RedirectToAction("Index");
         }

         return View(period);
      }

      // GET: Periods/Edit/5
      public ActionResult Edit(string id) {
         if(id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         Period period = db.Periods.Find(id);
         if(period == null) {
            return HttpNotFound();
         }
         return View(period);
      }

      // POST: Periods/Edit/5
      // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
      // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit([Bind(Include = "PeriodId,Year,Quaretr,DateFirst,DateEnd,Editable,Browsable")] Period period) {
         if(ModelState.IsValid) {
            db.Entry(period).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
         }
         return View(period);
      }

      // GET: Periods/Delete/5
      public ActionResult Delete(string id) {
         if(id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         Period period = db.Periods.Find(id);
         if(period == null) {
            return HttpNotFound();
         }
         return View(period);
      }

      // POST: Periods/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public ActionResult DeleteConfirmed(string id) {
         Period period = db.Periods.Find(id);
         db.Periods.Remove(period);
         db.SaveChanges();
         return RedirectToAction("Index");
      }

      protected override void Dispose(bool disposing) {
         if(disposing) {
            db.Dispose();
         }
         base.Dispose(disposing);
      }
   }
}
