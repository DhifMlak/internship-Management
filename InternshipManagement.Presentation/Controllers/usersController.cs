using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Net.Mail;

using System.Web.Mvc;
using InternshipManagement.Presentation.Models;

namespace InternshipManagement.Presentation.Controllers
{
    public class usersController : Controller
    {
        private Internship db = new Internship();

        // GET: users
        public async Task<ActionResult> Index()
        {
            var users = db.users.Include(u => u.university).Include(u => u.sheet).Where(u => u.sheet_id != null);

            return View(await users.ToListAsync());
        }
        public async Task<ActionResult> IndexWithoutFiche()
        {
            var users = db.users.Include(u => u.university).Include(u => u.sheet).Where(u=>u.sheet_id == null);
            
            return View(await users.ToListAsync());
        }


        public  void sendMail(string email)
        {
            var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress(email));  // replace with valid value 
            message.From = new MailAddress("directeur.stages@gmail.com");  // replace with valid value
            message.Subject = "Reminder";
            message.Body = string.Format(body, "Reminder", "no-reply@internship.com", "You must fill your sheet");
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "directeur.stages@gmail.com",  // replace with valid value
                    Password = "1234wK@@"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }


        }


        public  ActionResult Reminder()
        {
            var users = db.users.Include(u => u.university).Include(u => u.sheet).Where(u => u.sheet_id != null);
            foreach (user element in users)
            {
                sendMail(element.email);
            }
              return RedirectToAction("IndexWithoutFiche");

        }


        // GET: users/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = await db.users.FindAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: users/Create
        public ActionResult Create()
        {
            ViewBag.univerity_id = new SelectList(db.universities, "id", "email");
            return View();
        }

        // POST: users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "id,activated,descriminator,email,first_name,lang_key,last_name,login,password,reset_key,token,univerity_id")] user user)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(user);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.univerity_id = new SelectList(db.universities, "id", "email", user.univerity_id);
            return View(user);
        }

        // GET: users/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = await db.users.FindAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.univerity_id = new SelectList(db.universities, "id", "email", user.univerity_id);
            return View(user);
        }

        // POST: users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "id,activated,descriminator,email,first_name,lang_key,last_name,login,password,reset_key,token,univerity_id")] user user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.univerity_id = new SelectList(db.universities, "id", "email", user.univerity_id);
            return View(user);
        }

        // GET: users/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = await db.users.FindAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            user user = await db.users.FindAsync(id);
            db.users.Remove(user);
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
