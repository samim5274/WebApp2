using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppTest2.Models;

namespace WebAppTest2.Controllers
{
    public class TedtController : Controller
    {
        // GET: Tedt
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RegFrom()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(string stdName, int stdAge, string stdNationality)
        {
            //return Content($"Name: {stdName}, Age: {stdAge}, Nationality: {stdNationality}");

            ViewBag.name = stdName;
            ViewBag.age = stdAge;
            ViewBag.national = stdNationality;

            return View();
        }

        public ActionResult CourseRegistationForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registation(Student std)
        {
            return View("ShowData", std);
        }
    }
}