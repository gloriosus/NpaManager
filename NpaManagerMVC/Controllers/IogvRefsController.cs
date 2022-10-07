using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NpaManagerMVC.Models {
   public class IogvRefsController:Controller {
      private NpaDbContext db = new NpaDbContext();

      // GET: IogvRefs
      public ActionResult Index() {
         var list = db.IogvRefs.ToList();
         return View(list);
      }

      // GET: IogvRefs/Details/5
      public ActionResult Details(string id) {
         if(id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         IogvRef iogvRef = db.IogvRefs.Find(id);
         if(iogvRef == null) {
            return HttpNotFound();
         }
         return View(iogvRef);
      }

      // GET: IogvRefs/Create
      public ActionResult Create() {
         return View();
      }

      // POST: IogvRefs/Create
      // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
      // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create([Bind(Include = "Iogv")] IogvRef iogvRef) {
         if(ModelState.IsValid) {
            db.IogvRefs.Add(iogvRef);
            db.SaveChanges();
            return RedirectToAction("Index");
         }

         return View(iogvRef);
      }

      // GET: IogvRefs/Edit/5
      public ActionResult Edit(string id) {
         if(id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         IogvRef iogvRef = db.IogvRefs.Find(id);
         if(iogvRef == null) {
            return HttpNotFound();
         }
         return View(iogvRef);
      }

      // POST: IogvRefs/Edit/5
      // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
      // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit([Bind(Include = "Iogv")] IogvRef iogvRef) {
         if(ModelState.IsValid) {
            db.Entry(iogvRef).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
         }
         return View(iogvRef);
      }

      // GET: IogvRefs/Delete/5
      public ActionResult Delete(string id) {
         if(id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         IogvRef iogvRef = db.IogvRefs.Find(id);
         if(iogvRef == null) {
            return HttpNotFound();
         }
         return View(iogvRef);
      }

      // POST: IogvRefs/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public ActionResult DeleteConfirmed(string id) {
         IogvRef iogvRef = db.IogvRefs.Find(id);
         db.IogvRefs.Remove(iogvRef);
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
