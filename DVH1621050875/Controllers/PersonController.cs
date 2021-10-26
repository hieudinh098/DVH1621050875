using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DVH1621050875.Models;
namespace DVH1621050875.Controllers
{
    public class PersonController : BaseController
    {

        public ActionResult Index()
        {
            var data = db.People.ToList();
            return View(data);
        }

        public ActionResult Create()
		{
            return View(new Person());
		}

        [HttpPost]
        public ActionResult Create(Person model)
        {
            model.PersonId = GetId(PERSON_PREFIX);
            db.People.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            return View(db.People.Find(id));
        }

        public ActionResult Details(string id)
        {
            return View(db.People.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Person model)
        {
            var person = db.People.Find(model.PersonId);
            person.PersonName = model.PersonName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            var person = db.People.Find(id);
            db.People.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}