using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class DoctorEntitiesController : Controller
    {
        private MedContext db = new MedContext();

        // GET: DoctorEntities
        public async Task<ActionResult> Index()
        {
            return View(await db.People.ToListAsync());
        }

        // GET: DoctorEntities/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorEntity doctorEntity = await db.Doctors.FindAsync(id);
            if (doctorEntity == null)
            {
                return HttpNotFound();
            }
            return View(doctorEntity);
        }

        // GET: DoctorEntities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorEntities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,FirstName,LastName,Age,Email,Password,Information,Location")] DoctorEntity doctorEntity)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(doctorEntity);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(doctorEntity);
        }

        // GET: DoctorEntities/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorEntity doctorEntity = await db.Doctors.FindAsync(id);
            if (doctorEntity == null)
            {
                return HttpNotFound();
            }
            return View(doctorEntity);
        }

        // POST: DoctorEntities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,FirstName,LastName,Age,Email,Password,Information,Location")] DoctorEntity doctorEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorEntity).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(doctorEntity);
        }

        // GET: DoctorEntities/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorEntity doctorEntity = await db.Doctors.FindAsync(id);
            if (doctorEntity == null)
            {
                return HttpNotFound();
            }
            return View(doctorEntity);
        }

        // POST: DoctorEntities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DoctorEntity doctorEntity = await db.Doctors.FindAsync(id);
            db.People.Remove(doctorEntity);
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
