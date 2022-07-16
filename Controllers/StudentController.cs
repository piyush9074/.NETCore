using MyFirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ ID=1, Name = "Piyush", Address="32 Ram Bagh"},
                new Student(){ ID=2, Name = "Akul", Address="2 Kesar Bagh"},
                new Student(){ ID=3, Name = "Anjali", Address="3 JaiRam Nagar"}
            };
            
            return View(students);
        }
    }
}