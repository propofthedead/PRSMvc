using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrsMvc.Models;

namespace PrsMvc.Controllers
{
    public class PurchaseRequestLinesController : Controller
    {
        private PrsMvcContext db = new PrsMvcContext();

        // GET: PurchaseRequestLines
        public ActionResult Index()
        {
            return View(db.PurchaseRequestLines.ToList());
        }

        // GET: PurchaseRequestLines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseRequestLine purchaseRequestLine = db.PurchaseRequestLines.Find(id);
            if (purchaseRequestLine == null)
            {
                return HttpNotFound();
            }
            return View(purchaseRequestLine);
        }

        // GET: PurchaseRequestLines/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurchaseRequestLines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PurchaseRequestId,ProductId,Quanity,Price")] PurchaseRequestLine purchaseRequestLine)
        {
            if (ModelState.IsValid)
            {
                db.PurchaseRequestLines.Add(purchaseRequestLine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(purchaseRequestLine);
        }

        // GET: PurchaseRequestLines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseRequestLine purchaseRequestLine = db.PurchaseRequestLines.Find(id);
            if (purchaseRequestLine == null)
            {
                return HttpNotFound();
            }
            return View(purchaseRequestLine);
        }

        // POST: PurchaseRequestLines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PurchaseRequestId,ProductId,Quanity,Price")] PurchaseRequestLine purchaseRequestLine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(purchaseRequestLine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(purchaseRequestLine);
        }

        // GET: PurchaseRequestLines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PurchaseRequestLine purchaseRequestLine = db.PurchaseRequestLines.Find(id);
            if (purchaseRequestLine == null)
            {
                return HttpNotFound();
            }
            return View(purchaseRequestLine);
        }

        // POST: PurchaseRequestLines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PurchaseRequestLine purchaseRequestLine = db.PurchaseRequestLines.Find(id);
            db.PurchaseRequestLines.Remove(purchaseRequestLine);
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
