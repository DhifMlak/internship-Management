using InternshipManagement.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternshipManagement.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private Internship db = new Internship();

        public ActionResult Index()
        {
            if (Session["LoggedUserType"] == "Directeur")
            {
                ViewBag.Title = "Home Page";

                return View();
            }
            else
            {
                return RedirectToAction("Login");

            }
        }

        public ActionResult Logout()
        {
            Session["LoggedUser"] = null;
            Session["LoggedUserType"] = null;
            Session["LoggedUserID"] = null;
            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "Email,Password")] Login login)
        {
            var exists = db.users.Where(js =>
                js.email == login.Email
                && js.password == login.Password)
                .FirstOrDefault();

            if (exists != null)
            {
                Session["LoggedUser"] = exists.first_name + exists.last_name;
                Session["LoggedUserType"] = "Directeur";
                Session["LoggedUserID"] = exists.id;
                return RedirectToAction("Index");
            }

            ViewBag.MessageErrorLogin = "Email or Password invalids";

            return View();
        }




    }
}
