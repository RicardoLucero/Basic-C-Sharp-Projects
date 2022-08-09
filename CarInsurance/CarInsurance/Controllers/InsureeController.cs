using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            //if (ModelState.IsValid)
            //{
            //    db.Insurees.Add(insuree);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            insuree.Quote = 50m;
            int age = 0;
            age = DateTime.Now.Year - insuree.DateOfBirth.Year;

            if (age <= 18)
            {
                insuree.Quote = insuree.Quote + 100m;
            }
            else if (age >= 19 && age <= 25)
            {
                insuree.Quote = insuree.Quote + 50m;
            }
            else if (age > 25)
            {
                insuree.Quote = insuree.Quote + 25m;
            }

            int carYear1 = 2000;
            int carYear2 = 2015;
            if (insuree.CarYear < carYear1)
            {
                insuree.Quote = insuree.Quote + 25m;
            }
            else if (insuree.CarYear > carYear2)
            {
                insuree.Quote = insuree.Quote + 25m;
            }

            string carMake = "Porsche";
            if (insuree.CarMake == carMake)
            {
                insuree.Quote = insuree.Quote + 25m;
            }

            string carModel = "911 Carrera";
            if (insuree.CarModel == carModel)
            {
                insuree.Quote = insuree.Quote + 25m;
            }

            int speedingTickets = 0;
            if (insuree.SpeedingTickets > speedingTickets)
            {
                insuree.Quote = insuree.Quote + (10 * insuree.SpeedingTickets);
            }
            
            if (insuree.DUI == true)
            {
                insuree.Quote = insuree.Quote *= 1.25m;
            }

            if (insuree.CoverageType == true)
            {
                insuree.Quote = insuree.Quote *= 1.50m;
            }

            db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");

        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quotes = db.Insurees;
                var adminQuotes = new List<Insuree>();
                foreach (var quote in quotes)
                {
                    var adminQuote = new Insuree();
                    adminQuote.FirstName = quote.FirstName;
                    adminQuote.LastName = quote.LastName;
                    adminQuote.EmailAddress = quote.EmailAddress;
                    adminQuote.Quote = quote.Quote;
                    adminQuotes.Add(adminQuote);
                }
                return View(adminQuotes);
            }           
        }
    }
}
