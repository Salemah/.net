using Form_Submission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Form_Submission.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public ActionResult Addd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Addd(Student st)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name = st.Name;
                return RedirectToAction("Submit");
            }
            return View(st);
        }
        
      
        public ActionResult Submit( FormCollection form)
        {
            /*
            ViewBag.Name = Request["Name"];
            ViewBag.Id= Request["Id"];
            ViewBag.Dob= Request["Dob"];
            */
            ViewBag.Name = form["Name"];
            ViewBag.Id = form["Id"];
            ViewBag.Dob = form["Dob"];
            return View();
        }
    }
}