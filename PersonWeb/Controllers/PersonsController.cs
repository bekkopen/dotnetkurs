using System.Data;
using System.Linq;
using System.Web.Mvc;
using PersonWeb.Models;

namespace PersonWeb.Controllers
{
    public class PersonsController : Controller
    {
        public ActionResult Index()
        {
            using(var db = new PersonContext())
            {
                var persons = from p in db.Persons select p;
                return View(persons.ToList());
            }
        }

        public ActionResult List()
        {
            using (var db = new PersonContext())
            {
                var persons = from p in db.Persons select p;
                return Json(persons.ToList(), JsonRequestBehavior.AllowGet);
            }            
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Person person)
        {            
            if (ModelState.IsValid)
            {
                using(var db = new PersonContext())
                {
                    db.Persons.Add(person);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Update(int id)
        {
            using(var db = new PersonContext())
            {
                return View(db.Persons.Find(id));
            }
        }

        [HttpPost]
        public ActionResult Update(Person person)
        {
            using(var db = new PersonContext())
            {
                db.Persons.Attach(person);
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult DeleteConfirm(int id)
        {
            using(var db = new PersonContext())
            {
                return View(db.Persons.Find(id));
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            using(var db = new PersonContext())
            {
                var p = db.Persons.Find(id);
                db.Entry(p).State = EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        private static Person[] LagPersoner()
        {
            var personer = new[] {
                new Person { Name="Patric Bateman", Age=27, HairColor="Brun", Height=184, Gender="M"},
                new Person { Name="Mystique", Age=127, HairColor="Rød", Height=177, Gender="K"},
                new Person { Name="Two Face", Age=58, HairColor="Brun", Height=183, Gender="M"},
                new Person { Name="Cruella De Vil", Age=65, HairColor="Svart og hvitt", Height=168, Gender="K"},
                new Person { Name="Orochimaru", Age=100, HairColor="Svart", Height=180, Gender="M"},
                new Person { Name="Harvey Dent", Age=56, HairColor="Brun", Height=183, Gender="M"},
                new Person { Name="KongenDin", Age=75, HairColor="Ukjent", Height=150, Gender="M"}
            };
            return personer;
        }  
    }
}