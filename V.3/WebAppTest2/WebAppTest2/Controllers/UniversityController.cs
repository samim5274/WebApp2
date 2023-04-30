using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppTest2.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dept()
        {
            string[] DeptList = { "CSE", "EEE", "BBA","DBA", "English" };
            ViewBag.dept = DeptList;
            return View();
        }

        public ActionResult Course()
        {
            string[] courseList = { "Matrix and Algebra", "Neumerical Stadis","Data Structure","C# Programming","Database Manegment"};
            ViewBag.list = courseList;
            return View();
        }

        public ActionResult Degree()
        {
            return View();
        }

        public ActionResult Programs()
        {
            return RedirectToAction("Dept");
        }
    }
}