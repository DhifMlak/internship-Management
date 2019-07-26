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
    public class sheetsController : Controller
    {
        private Internship db = new Internship();

        // GET: sheets
        public async Task<ActionResult> Index()
        {
            

            var sheets = db.sheets.Include(s => s.category).Include(s => s.enterprise);
            return View(await sheets.ToListAsync());
        }

        // GET: sheets/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sheet sheet = await db.sheets.FindAsync(id);
            if (sheet == null)
            {
                return HttpNotFound();
            }
            return View(sheet);
        }

        // GET: sheets/Create
        public ActionResult Create()
        {
            ViewBag.cat_id = new SelectList(db.categories, "id", "label");
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1");
            return View();
        }

        // POST: sheets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,created,description,internship_director_validation,problematique,project_title,student_name,updated,cat_id,enterprise_id")] sheet sheet)
        {
            if (ModelState.IsValid)
            {
                db.sheets.Add(sheet);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            return View(sheet);
        }

        // GET: sheets/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sheet sheet = await db.sheets.FindAsync(id);
            if (sheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            return View(sheet);
        }

        // POST: sheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,created,description,internship_director_validation,problematique,project_title,student_name,updated,cat_id,enterprise_id")] sheet sheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sheet).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            return View(sheet);
        }


        public async Task<ActionResult> Accept(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sheet sheet = await db.sheets.FindAsync(id);
            if (sheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            sheet.etat = "Accepted";
            return View(sheet);
        }

        // POST: sheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Accept([Bind(Include = "id,created,etat,description,internship_director_validation,problematique,project_title,student_name,updated,cat_id,enterprise_id")] sheet sheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sheet).State = EntityState.Modified;
                
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            return View(sheet);
        }

        public async Task<ActionResult> RefuseWithdrawal(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sheet sheet = await db.sheets.FindAsync(id);
            if (sheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            sheet.etat = "Accepted";
            return View(sheet);
        }

        // POST: sheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RefuseWithdrawal([Bind(Include = "id,created,etat,note,description,internship_director_validation,problematique,project_title,student_name,updated,cat_id,enterprise_id")] sheet sheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sheet).State = EntityState.Modified;

                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            return View(sheet);
        }

        public async Task<ActionResult> AcceptWithdrawal(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sheet sheet = await db.sheets.FindAsync(id);
            if (sheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            sheet.etat = "Archived";
            return View(sheet);
        }

        // POST: sheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AcceptWithdrawal([Bind(Include = "id,created,etat,note,description,internship_director_validation,problematique,project_title,student_name,updated,cat_id,enterprise_id")] sheet sheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sheet).State = EntityState.Modified;

                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            return View(sheet);
        }





        public async Task<ActionResult> Refuse(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sheet sheet = await db.sheets.FindAsync(id);
            if (sheet == null)
            {
                return HttpNotFound();
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            sheet.etat = "Refused";
            return View(sheet);
        }

        // POST: sheets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Refuse([Bind(Include = "id,created,etat,note,description,internship_director_validation,problematique,project_title,student_name,updated,cat_id,enterprise_id")] sheet sheet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sheet).State = EntityState.Modified;

                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.cat_id = new SelectList(db.categories, "id", "label", sheet.cat_id);
            ViewBag.enterprise_id = new SelectList(db.enterprises, "id", "address1", sheet.enterprise_id);
            return View(sheet);
        }

     

        public async Task<ActionResult> NotTreated()
        {
            var sheets = db.sheets.Include(s => s.category).Include(s => s.enterprise).Where(s => s.etat == "Not Treated");
            return View(await sheets.ToListAsync());
        }

        public async Task<ActionResult> Archive()
        {
            var sheets = db.sheets.Include(s => s.category).Include(s => s.enterprise).Where(s => s.etat == "Archived");
            return View(await sheets.ToListAsync());
        }


        public async Task<ActionResult> Pending()
        {
            var sheets = db.sheets.Include(s => s.category).Include(s => s.enterprise).Where(s => s.etat == "Pending");
            return View(await sheets.ToListAsync());
        }

        public async Task<ActionResult> Withdrawals()
        {
            var sheets = db.sheets.Include(s => s.category).Include(s => s.enterprise).Where(s => s.etat == "Pending Withdrawal");
            return View(await sheets.ToListAsync());
        }

        // GET: sheets/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sheet sheet = await db.sheets.FindAsync(id);
            if (sheet == null)
            {
                return HttpNotFound();
            }
            return View(sheet);
        }

        // POST: sheets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            sheet sheet = await db.sheets.FindAsync(id);
            db.sheets.Remove(sheet);
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
