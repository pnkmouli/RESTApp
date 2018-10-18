using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Domain;

namespace App.Controllers
{
    public class PropertyAlertsController : Controller
    {
        private WaltonPropertiesEntities db = new WaltonPropertiesEntities();

        // GET: PropertyAlerts
        public ActionResult Index()
        {
            var propertyAlerts = db.PropertyAlerts.Include(p => p.ApplicantTitle);
            return View(propertyAlerts.ToList());
        }

        // GET: PropertyAlerts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyAlert propertyAlert = db.PropertyAlerts.Find(id);
            if (propertyAlert == null)
            {
                return HttpNotFound();
            }
            return View(propertyAlert);
        }

        // GET: PropertyAlerts/Create
        public ActionResult Create()
        {
            ViewBag.Title = new SelectList(db.ApplicantTitles, "ID", "Name");
            return View();
        }

        // POST: PropertyAlerts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Forename,Surname,EmailAddress,Telephone,PropertyTypeIDs,PropertyTypeTitles,MinPrice,MaxPrice,MinBedrooms,MaxBedrooms,Location,Radius,Latitude,Longitude,SubscriptionStartDate,SubscriptionExpiryDate,SubscriptionCode,DateProcessed,Active,PPPW,PCM,Portfolios,Terms,CategoryId,ClientType,SortOrder,IsAlert,AddedBy")] PropertyAlert propertyAlert)
        {
            if (ModelState.IsValid)
            {
                db.PropertyAlerts.Add(propertyAlert);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Title = new SelectList(db.ApplicantTitles, "ID", "Name", propertyAlert.Title);
            return View(propertyAlert);
        }

        // GET: PropertyAlerts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyAlert propertyAlert = db.PropertyAlerts.Find(id);
            if (propertyAlert == null)
            {
                return HttpNotFound();
            }
            ViewBag.Title = new SelectList(db.ApplicantTitles, "ID", "Name", propertyAlert.Title);
            return View(propertyAlert);
        }

        // POST: PropertyAlerts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Forename,Surname,EmailAddress,Telephone,PropertyTypeIDs,PropertyTypeTitles,MinPrice,MaxPrice,MinBedrooms,MaxBedrooms,Location,Radius,Latitude,Longitude,SubscriptionStartDate,SubscriptionExpiryDate,SubscriptionCode,DateProcessed,Active,PPPW,PCM,Portfolios,Terms,CategoryId,ClientType,SortOrder,IsAlert,AddedBy")] PropertyAlert propertyAlert)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propertyAlert).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Title = new SelectList(db.ApplicantTitles, "ID", "Name", propertyAlert.Title);
            return View(propertyAlert);
        }

        // GET: PropertyAlerts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyAlert propertyAlert = db.PropertyAlerts.Find(id);
            if (propertyAlert == null)
            {
                return HttpNotFound();
            }
            return View(propertyAlert);
        }

        // POST: PropertyAlerts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PropertyAlert propertyAlert = db.PropertyAlerts.Find(id);
            db.PropertyAlerts.Remove(propertyAlert);
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
