using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Diagnostics;

namespace Proiect3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login() 
        {
            Trace.WriteLine("Login Page opened");
            return RedirectToAction("Login", "Account");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ChangeLanguage(string lang)
        {
            Session["lang"] = lang;

            return RedirectToAction("Index", "Home",
                new { language = lang });
        }
    }
}