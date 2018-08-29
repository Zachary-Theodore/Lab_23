using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab23.Models;

namespace Lab23.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Lab23DBEntities ORM = new Lab23DBEntities();
            ViewBag.Items = ORM.lab23items.ToList();
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

        public ActionResult RegisterUser()
        {
            
            return View();
        }

        public ActionResult NewUser(lab23users newUser)
        {
            Lab23DBEntities ORM = new Lab23DBEntities();

            ORM.lab23users.Add(newUser);
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}