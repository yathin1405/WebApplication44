using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication44.Data;
using WebApplication44.Models;

namespace WebApplication44.Controllers
{
    public class UserCruisesController : Controller
    {
        private WebApplication44Context db = new WebApplication44Context();

        // GET: UserCruises
        public ActionResult Index()
        {
            return View(db.UserCruises.ToList());
        }

        // GET: UserCruises/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserCruise userCruise = db.UserCruises.Find(id);
            if (userCruise == null)
            {
                return HttpNotFound();
            }
            return View(userCruise);
        }

        // GET: UserCruises/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserCruises/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CruiseID,Ship_name,FROM,TO,Ship_Type,Cruise_Duration,Num_Adults,Num_Kids,Departure_Date,Email,Ship_Fee,Discount,Total")] UserCruise userCruise)
        {
            if (ModelState.IsValid)
            {
                userCruise.Ship_Fee = userCruise.ShipFee();
                userCruise.Discount = userCruise.discount();
                userCruise.TotalTickets = userCruise.numOfTickets();
                userCruise.Total = userCruise.TotalCost();
                db.UserCruises.Add(userCruise);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userCruise);
        }

        // GET: UserCruises/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserCruise userCruise = db.UserCruises.Find(id);
            if (userCruise == null)
            {
                return HttpNotFound();
            }
            return View(userCruise);
        }

        // POST: UserCruises/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CruiseID,Ship_name,FROM,TO,Ship_Type,Cruise_Duration,Num_Adults,Num_Kids,Departure_Date,Email,Ship_Fee,Discount,Total")] UserCruise userCruise)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userCruise).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userCruise);
        }

        // GET: UserCruises/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserCruise userCruise = db.UserCruises.Find(id);
            if (userCruise == null)
            {
                return HttpNotFound();
            }
            return View(userCruise);
        }

        // POST: UserCruises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserCruise userCruise = db.UserCruises.Find(id);
            db.UserCruises.Remove(userCruise);
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
