using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//HomeController.cs
//Amanda Field - 200267851, Anthony Gobin - 200296437, Robert Page
//OnTheRoX
//Account Controller, resposible for Index, About, Contact.

namespace COMP2007_S2016_FinalAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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