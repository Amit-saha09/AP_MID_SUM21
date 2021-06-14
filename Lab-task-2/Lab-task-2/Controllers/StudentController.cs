using Lab_task_2.Models;
using Lab_task_2.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_task_2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Database db = new Database();
            var students = db.Students.GetAll();
            return View(students);
        }

        public ActionResult Add()
        {
            Student p = new Student();
            return View(p);
        }
        [HttpPost]
        public ActionResult Add(Student p)
        {
            //insert to db
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(p);
                return RedirectToAction("Index");
            }
            return View();

        }
        public ActionResult Edit(int id)
        {

            Database db = new Database();
            var p = db.Students.Get(id);

            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Student p)
        {
            //update to db
            Database db = new Database();
            db.Students.Update(p);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {

            Database db = new Database();
            db.Students.Delete(id);

            return RedirectToAction("Index");
        }
    }
}