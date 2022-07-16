using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsEligibleForLoan { get; set; }
        public int Salary { get; set; }

    }
}