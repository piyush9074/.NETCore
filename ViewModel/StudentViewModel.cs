using MyFirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApp.ViewModel
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public IEnumerable<Subject> Subjects { get; set; }
    }
}