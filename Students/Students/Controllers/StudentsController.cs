using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Students.Models;

namespace Students.Controllers
{
    public class StudentsController : Controller
    {
        private List<Student> _students;

        public StudentsController() : base()
        {
            _students = InitStudents.Students();
        }
        
        public ActionResult Index()
        {
//            ViewBag.Students = _students;

            return View(_students);
        }
    }
}