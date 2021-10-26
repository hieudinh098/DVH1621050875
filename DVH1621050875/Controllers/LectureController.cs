using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DVH1621050875.Models;
namespace DVH1621050875.Controllers
{
    public class LectureController : BaseController
    {

        public ActionResult Index()
        {
            var data = db.Lectures.ToList();
            return View(data);
        }

        public ActionResult Create()
		{
            return View(new Lecture());
		}

        [HttpPost]
        public ActionResult Create(Lecture model)
        {
            model.PersonId = GetId(LECTURE_PREFIX);
            db.Lectures.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            return View(db.Lectures.Find(id));
        }

        public ActionResult Details(string id)
        {
            return View(db.Lectures.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Lecture model)
        {
            var std = db.Lectures.Find(model.PersonId);
            std.PersonName = model.PersonName;
            std.Department = model.Department;
            std.Faculty = model.Faculty;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            var std = db.Lectures.Find(id);
            db.Lectures.Remove(std);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}