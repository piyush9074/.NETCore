using MyFirstMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.FirstName = "Piyush";

            return View();
        }

        public ActionResult GetEmployees()
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee(){ 
                    Name="Piyush",
                    IsEligibleForLoan=false,
                    Address="68 Katju Colony",
                    JoiningDate=System.DateTime.Now,
                    ID=1,
                    Salary=200000
                },
                new Employee(){
                    Name="Anand",
                    IsEligibleForLoan=true,
                    Address="62 Katju Colony",
                    JoiningDate=System.DateTime.Now,
                    ID=1,
                    Salary=200000
                },

                new Employee()
                {
                    Name="Piyush",
                    IsEligibleForLoan=false,
                    Address="68 Katju Colony",
                    JoiningDate=System.DateTime.Now,
                    ID=1,
                    Salary=200000 },
                new Employee(){
                    Name="Aayush",
                    IsEligibleForLoan=false,
                    Address="61 Katju Colony",
                    JoiningDate=System.DateTime.Now,
                    ID=1,
                    Salary=1000000
                }
            };
            ViewBag.Employees = Employees;
            return View();
        }
    }
}