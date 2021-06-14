using Lab_task_2.Models;
using Lab_task_2.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_task_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin p)
        {
            //update to db
            Database db = new Database();
            var q = db.Admins.Get(p.Username, p.Password);
            if (q == p.Password)
            {
                return RedirectToAction("Home1");

            }
            return RedirectToAction("Index");
        }
        public ActionResult Home1()
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
    }
}