using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _403Project1.Controllers
{
    public class DegreeController : Controller
    {
        // GET: Degree
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Degree(string name)
        {
            switch (name){
            case "bsis":
                    @ViewBag.Degree = "BSIS";
                    @ViewBag.Coordinator = "Dr. Albrecht";
                    @ViewBag.CoordinatorTitle = "Director of BSIS";
                    @ViewBag.Address = "Something Tanner Building";
                    @ViewBag.PhD = "Stanford" ;
                    @ViewBag.Masters = "Vanderbilt";
                    @ViewBag.Bachelors = "BYU" ;
                    @ViewBag.Image = "http://bit.ly/2eX0QNA";
                    @ViewBag.FAQ1Q = "What are the required prerequisite courses?";
                    @ViewBag.FAQ2Q = "What is the required GPA to be accepted to the Junior Core?";
                    @ViewBag.FAQ3Q = "What is required in the application to the program?";
                    @ViewBag.FAQ1A = "ACC 200, FIN201, BUS M 241, IS110, IS201, IS303 (or CS 142).";
                    @ViewBag.FAQ2A = "A minimum GPA of 3.0 is required both overall, and for the prerequisite courses, but does not guarantee acceptance into the program.";
                    @ViewBag.FAQ3A = "In the application you will submit your grades, as well as a 500 word essay.";
                    break;
            case "mism":
                    @ViewBag.Degree = "MISM";
                    @ViewBag.Coordinator = "Dr. Bonnie Anderson";
                    @ViewBag.CoordinatorTitle = "Director of MISM";
                    @ViewBag.Address = "Something Tanner Building";
                    @ViewBag.PhD = "Yale";
                    @ViewBag.Masters = "Harvard";
                    @ViewBag.Bachelors = "BYU";
                    @ViewBag.Image = "http://bit.ly/2fk1lCH";
                    @ViewBag.FAQ1Q = "What skills will be developed in the MISM?";
                    @ViewBag.FAQ2Q = "What is the minimum GPA for MISM acceptance? What is the average GPA?";
                    @ViewBag.FAQ3Q = "When is the deadline to apply?";
                    @ViewBag.FAQ1A = "Students will develop a foundation of skills in Business Analytics, Security and Forensics, Development, IT Architecture, and Business Strategy.";
                    @ViewBag.FAQ2A = "The minimum GPA is a 3.0 for acceptance. The average GPA is 3.72.";
                    @ViewBag.FAQ3A = "Applications must be submitted by the last working day of March.";
                    break;
            }
            return View();
        }
    }

   
}