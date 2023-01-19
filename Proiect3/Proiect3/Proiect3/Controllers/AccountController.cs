using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Proiect3.Controllers
{
    public class AccountController : Controller
    {
        UserModelDbContext dbContext = new UserModelDbContext();

        [HttpGet]
        public ActionResult Login()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            using (UserModelDbContext ut = new UserModelDbContext())
            {
                var rez = from s in ut.Users
                          where s.Username.Equals(model.Username)
                          select new
                          {
                              s.Username,
                              s.Password
                          };

                if (rez.Count() != 0)
                {
                    if (rez.First().Password == model.Password)
                        return RedirectToAction("Index", "Shop");
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Register()
        {
            UserModel user = new UserModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return RedirectToAction("Login", "Account");
        }
        
    }
}