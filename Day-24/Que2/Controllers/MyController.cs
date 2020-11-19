using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCwithEF.Models;

namespace MVCwithEF.Controllers
{
    public class MyController : Controller
    {
        private mydbEntities db = new mydbEntities();

        //
        // GET: /My/

        public ActionResult Index()
        {
            return View(db.Emps.ToList());
        }

        //
        // GET: /My/Details/5

        public ActionResult Details(int id)
        {
            Emp emp = db.Emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        //
        // GET: /My/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /My/Create

        [HttpPost]
        public ActionResult Create(Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Emps.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }

        //
        // GET: /My/Edit/5

        public ActionResult Edit(int id)
        {
            Emp emp = db.Emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        //
        // POST: /My/Edit/5

        [HttpPost]
        public ActionResult Edit(Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        //
        // GET: /My/Delete/5

        public ActionResult Delete(int id)
        {
            Emp emp = db.Emps.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        //
        // POST: /My/Delete/5//, ActionName("Delete")

        [HttpPost]
        public ActionResult Delete(Emp e)
        {
            Emp emp = db.Emps.Find(e.Id);
            db.Emps.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}