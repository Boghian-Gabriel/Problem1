using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SingletonMVC.Models;
using SingletonMVC.Logger;

namespace SingletonMVC.Controllers
{
    public class EmployeeSingletonsController : Controller
    {

        private readonly ILogger ilog;
        private EmployeeDB1 db = new EmployeeDB1();

        public EmployeeSingletonsController()
        {
            ilog = Log.GetInstance;
        }

        // GET: EmployeeSingletons
        public async Task<ActionResult> Index()
        {
            return View(await db.EmployeeSingletons.ToListAsync());
        }

        // GET: EmployeeSingletons/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            ilog.LogException("Some exception Occured");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSingleton employeeSingleton = await db.EmployeeSingletons.FindAsync(id);
            if (employeeSingleton == null)
            {
                return HttpNotFound();
            }
            ilog.LogException("Some exception Occured");
            return View(employeeSingleton);
        }

        // GET: EmployeeSingletons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeSingletons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,name,gender,salary,department")] EmployeeSingleton employeeSingleton)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeSingletons.Add(employeeSingleton);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(employeeSingleton);
        }

        // GET: EmployeeSingletons/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSingleton employeeSingleton = await db.EmployeeSingletons.FindAsync(id);
            if (employeeSingleton == null)
            {
                return HttpNotFound();
            }
            return View(employeeSingleton);
        }

        // POST: EmployeeSingletons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,name,gender,salary,department")] EmployeeSingleton employeeSingleton)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeSingleton).State = (System.Data.Entity.EntityState)System.Data.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employeeSingleton);
        }

        // GET: EmployeeSingletons/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSingleton employeeSingleton = await db.EmployeeSingletons.FindAsync(id);
            if (employeeSingleton == null)
            {
                return HttpNotFound();
            }
            return View(employeeSingleton);
        }

        // POST: EmployeeSingletons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            EmployeeSingleton employeeSingleton = await db.EmployeeSingletons.FindAsync(id);
            db.EmployeeSingletons.Remove(employeeSingleton);
            await db.SaveChangesAsync();
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
