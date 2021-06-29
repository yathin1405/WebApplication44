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
    public class UserQuotesController : Controller
    {
        private WebApplication44Context db = new WebApplication44Context();

        // GET: UserQuotes
        public ActionResult Index()
        {
            return View(db.UserQuotes.ToList());
        }

        // GET: UserQuotes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserQuote userQuote = db.UserQuotes.Find(id);
            if (userQuote == null)
            {
                return HttpNotFound();
            }
            return View(userQuote);
        }

        // GET: UserQuotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserQuotes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,TourL,FirstName,LastName,EmailAddress,PhoneNumber,NumAdults,NumKids,DepartureDate,ReturnDate,Hotels,Tours,Cruises,Flights")] UserQuote userQuote)
        {
            if (ModelState.IsValid)
            {
                db.UserQuotes.Add(userQuote);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userQuote);
        }

        // GET: UserQuotes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserQuote userQuote = db.UserQuotes.Find(id);
            if (userQuote == null)
            {
                return HttpNotFound();
            }
            return View(userQuote);
        }

        // POST: UserQuotes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,TourL,FirstName,LastName,EmailAddress,PhoneNumber,NumAdults,NumKids,DepartureDate,ReturnDate,Hotels,Tours,Cruises,Flights")] UserQuote userQuote)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userQuote).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userQuote);
        }

        // GET: UserQuotes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserQuote userQuote = db.UserQuotes.Find(id);
            if (userQuote == null)
            {
                return HttpNotFound();
            }
            return View(userQuote);
        }

        // POST: UserQuotes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserQuote userQuote = db.UserQuotes.Find(id);
            db.UserQuotes.Remove(userQuote);
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
