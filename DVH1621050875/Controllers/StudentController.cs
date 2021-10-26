using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DVH1621050875.Models;
namespace DVH1621050875.Controllers
{
    public class StudentController : BaseController
    {

        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        public ActionResult Create()
		{
            return View(new Student());
		}

        [HttpPost]
        public ActionResult Create(Student model)
        {
            model.PersonId = GetId(STUDENT_PREFIX);
            db.Students.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            return View(db.Students.Find(id));
        }

        public ActionResult Details(string id)
        {
            return View(db.Students.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Student model)
        {
            var std = db.Students.Find(model.PersonId);
            std.PersonName = model.PersonName;
            std.Address = model.Address;
            std.University = model.University;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            var std = db.Students.Find(id);
            db.Students.Remove(std);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}