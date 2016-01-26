using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RateApp.Models;

namespace RateApp.Controllers
{
    public class ThingController : Controller
    {
        private ThingContext db = new ThingContext();

        // GET: /Thing/
        public ActionResult Index()
        {
            return View(db.Things.ToList());
        }

        // GET: /Thing/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thing thing = db.Things.Find(id);
            if (thing == null)
            {
                return HttpNotFound();
            }
            return View(thing);
        }

        // GET: /Thing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Thing/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Type,Location,City,State,Country,Zipcode")] Thing thing)
        {
            if (ModelState.IsValid)
            {
                db.Things.Add(thing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thing);
        }

        // GET: /Thing/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thing thing = db.Things.Find(id);
            if (thing == null)
            {
                return HttpNotFound();
            }
            return View(thing);
        }

        // POST: /Thing/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Type,Location,City,State,Country,Zipcode")] Thing thing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thing);
        }

        // GET: /Thing/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thing thing = db.Things.Find(id);
            if (thing == null)
            {
                return HttpNotFound();
            }
            return View(thing);
        }

        // POST: /Thing/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Thing thing = db.Things.Find(id);
            db.Things.Remove(thing);
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
