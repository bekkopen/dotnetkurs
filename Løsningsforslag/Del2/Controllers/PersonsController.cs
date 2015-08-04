using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Del2.Models;

namespace Del2.Controllers
{
    public class PersonsController : Controller
    {
        private readonly PersonsContext _db = new PersonsContext();

        public ActionResult Index()
        {
            var persons = _db.People.ToList();
            return View(persons);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);

            _db.People.Add(person);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var person = _db.People.Find(id);
            return View(person);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Update(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);

            _db.Entry(person).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var person = _db.People.Find(id);
            return View(person);
        }

        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
            var person = _db.People.Find(id);
            _db.People.Remove(person);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        //public ActionResult Index()
        //{
        //    var persons = LagPersoner();
        //    return View(persons);
        //}

        //private static Person[] LagPersoner()
        //{
        //    var personer = new[] {
        //        new Person { Name="Patric Bateman", Age=27, HairColor="Brun", Height=184, Gender="M"},
        //        new Person { Name="Mystique", Age=127, HairColor="Rød", Height=177, Gender="K"},
        //        new Person { Name="Two Face", Age=58, HairColor="Brun", Height=183, Gender="M"},
        //        new Person { Name="Cruella De Vil", Age=65, HairColor="Svart og hvitt", Height=168, Gender="K"},
        //        new Person { Name="Orochimaru", Age=100, HairColor="Svart", Height=180, Gender="M"},
        //        new Person { Name="Harvey Dent", Age=56, HairColor="Brun", Height=183, Gender="M"},
        //        new Person { Name="Kongen Harald", Age=78, HairColor="Ukjent", Height=150, Gender="M"}
        //    };
        //    return personer;
        //}
    }
}