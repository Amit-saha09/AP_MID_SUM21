using Lab_task_2.Models;
using Lab_task_2.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_task_2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            Database db = new Database();
            var departments = db.Departments.GetAll();
            return View(departments);
        }

        public ActionResult Add()
        {
            Department p = new Department();
            return View(p);
        }
        [HttpPost]
        public ActionResult Add(Department p)
        {
            //insert to db
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Departments.Insert(p);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult Edit(int id)
        {

            Database db = new Database();
            var p = db.Departments.Get(id);

            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Department p)
        {
            //update to db
            Database db = new Database();
            db.Departments.Update(p);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {

            Database db = new Database();
            db.Departments.Delete(id);

            return RedirectToAction("Index");
        }
    }
}