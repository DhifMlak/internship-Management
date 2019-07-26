using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InternshipManagement.Presentation.Models;

namespace InternshipManagement.Presentation.Controllers
{
    public class final_project_assignmentController : Controller
    {
        private Internship db = new Internship();

        // GET: final_project_assignment
        public async Task<ActionResult> Index()
        {
            var final_project_assignment = db.final_project_assignment.Include(f => f.convention).Include(f => f.sheet).Include(f => f.user).Include(f => f.validation_group);
            return View(await final_project_assignment.ToListAsync());
        }

        // GET: final_project_assignment/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            final_project_assignment final_project_assignment = await db.final_project_assignment.FindAsync(id);
            if (final_project_assignment == null)
            {
                return HttpNotFound();
            }
            return View(final_project_assignment);
        }

        // GET: final_project_assignment/Create
        public ActionResult Create()
        {
            ViewBag.convention_name = new SelectList(db.conventions, "id", "id");
            ViewBag.sheet_id = new SelectList(db.sheets, "id", "description");
            ViewBag.student_id = new SelectList(db.users, "id", "descriminator");
            ViewBag.validation_group_id = new SelectList(db.validation_group, "id", "id");
            return View();
        }

        // POST: final_project_assignment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,convention_name,sheet_id,student_id,validation_group_id")] final_project_assignment final_project_assignment)
        {
            if (ModelState.IsValid)
            {
                db.final_project_assignment.Add(final_project_assignment);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.convention_name = new SelectList(db.conventions, "id", "id", final_project_assignment.convention_name);
            ViewBag.sheet_id = new SelectList(db.sheets, "id", "description", final_project_assignment.sheet_id);
            ViewBag.student_id = new SelectList(db.users, "id", "descriminator", final_project_assignment.student_id);
            ViewBag.validation_group_id = new SelectList(db.validation_group, "id", "id", final_project_assignment.validation_group_id);
            return View(final_project_assignment);
        }

        // GET: final_project_assignment/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            final_project_assignment final_project_assignment = await db.final_project_assignment.FindAsync(id);
            if (final_project_assignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.convention_name = new SelectList(db.conventions, "id", "id", final_project_assignment.convention_name);
            ViewBag.sheet_id = new SelectList(db.sheets, "id", "description", final_project_assignment.sheet_id);
            ViewBag.student_id = new SelectList(db.users, "id", "descriminator", final_project_assignment.student_id);
            ViewBag.validation_group_id = new SelectList(db.validation_group, "id", "id", final_project_assignment.validation_group_id);
            return View(final_project_assignment);
        }

        // POST: final_project_assignment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,convention_name,sheet_id,student_id,validation_group_id")] final_project_assignment final_project_assignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(final_project_assignment).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.convention_name = new SelectList(db.conventions, "id", "id", final_project_assignment.convention_name);
            ViewBag.sheet_id = new SelectList(db.sheets, "id", "description", final_project_assignment.sheet_id);
            ViewBag.student_id = new SelectList(db.users, "id", "descriminator", final_project_assignment.student_id);
            ViewBag.validation_group_id = new SelectList(db.validation_group, "id", "id", final_project_assignment.validation_group_id);
            return View(final_project_assignment);
        }

        // GET: final_project_assignment/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            final_project_assignment final_project_assignment = await db.final_project_assignment.FindAsync(id);
            if (final_project_assignment == null)
            {
                return HttpNotFound();
            }
            return View(final_project_assignment);
        }

        // POST: final_project_assignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            final_project_assignment final_project_assignment = await db.final_project_assignment.FindAsync(id);
            db.final_project_assignment.Remove(final_project_assignment);
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
