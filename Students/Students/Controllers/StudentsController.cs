using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Students.Models;
using System.Net;

namespace Students.Controllers
{
    public class StudentsController : Controller
    {
        private List<Student> _students;

        public StudentsController() : base()
        {
            _students = InitStudents._students;
        }
        
        public ActionResult Index()
        {
            return View(_students);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Student student = _students.Find(s => s.Id == id);

            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = _students.Find(s => s.Id == id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,MailAddress")] Student student)
        {
            if (ModelState.IsValid)
            {
                var tmp = _students.First(s => s.Id == student.Id);

                if (tmp != null)
                {
                    tmp.MailAddress = student.MailAddress;
                    tmp.Name = student.Name;
                    return RedirectToAction("Index");
                }
            }
            return View(student);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,MailAddress")] Student student)
        {

            if (ModelState.IsValid)
            {
                student.Id =_students.Select(s => s.Id).Max() + 1;

                _students.Add(student);

                return RedirectToAction("Index");
            }
            
            return View(student);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            var tmp = _students.First(s => s.Id == id);

            if (tmp == null) return HttpNotFound();
                        
            return View(tmp);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Student student = _students.First(s => s.Id == id);
            if (student == null)
            {
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }

            _students.Remove(student);

            return RedirectToAction("Index");
        }
    }
}