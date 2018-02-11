using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneilWebApplication.Classes;
using OneilWebApplication.Entities;

namespace OneilWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User _user = new User
            {
                FirstName = "Bob",
                LastName = "Smith",
                Id = 2,
                LoginName = "bsmith"
            };
            using(EntitiesOneilWebInterfaces _ef = new EntitiesOneilWebInterfaces())
            {
                _ef.Users.Add(_user);
                _ef.SaveChanges();
            }
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
    }
}