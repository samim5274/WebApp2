using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            //ViewBag.Message = "Welcome to my first application";   

            String[] fruits = { "apple", "Painapple", "Mango", "Banana" };
            ViewBag.fruits = fruits;

            return View();
        }

        public ActionResult Test2()
        {
            int[] fruits = { 10,11,12,13,14,15,16,17,18,19,20 };
            return View(fruits);
        }

        public ActionResult People()
        {
            Person p = new Person();
            p.Id = 101;
            p.Name = "SAMIM";
            p.Age = 23;
            p.Country = "Bangladesh";            
            
            return View(p);
        }

        public ActionResult AllPeople()
        {
            List<Person> People = new List<Person>()
            {
                new Person{ Id=1, Name="Samim",Age=20,Country="Bangladesh"},
                new Person{ Id=2, Name="Arif",Age=25,Country="India"},
                new Person{ Id=3, Name="Mahbub",Age=22,Country="Pakistan"},
                new Person{ Id=4, Name="Juel",Age=21,Country="Nepal"},
                new Person{ Id=5, Name="Nayem",Age=28,Country="USA"},
            };

            Person p = new Person();
            p.Id = 101;
            p.Name = "Kamal";
            p.Age = 23;
            p.Country = "Bangladesh";

            People.Add(p);

            return View(People);
        }

        public ActionResult MultiObject()
        {

            List<Emp> EmpList = new List<Emp>()
            {
                new Emp{Id=101, Name="Samim", Desig="Manager"},
                new Emp{Id=102, Name="Hasan", Desig="Assis-Manager"},
                new Emp{Id=103, Name="Mahfuz", Desig="Sr.Executive"},
                new Emp{Id=104, Name="Ajad", Desig="Executive"},
                new Emp{Id=105, Name="Kobir", Desig="Jr.Executive"}
            };
            List<Dept> DeptList = new List<Dept>()
            {
                new Dept{Id=101, Name="Rasel", HeadOfDept="Account"},
                new Dept{Id=101, Name="Abir", HeadOfDept="Sales"},
                new Dept{Id=101, Name="Munna", HeadOfDept="Production"}
            };

            Org objOrg = new Org()
            {
                Id = 1,
                Name = "XYZ",
                Address = "Dhaka",
                Department = DeptList,
                Employess = EmpList
            };

            return View(objOrg);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}