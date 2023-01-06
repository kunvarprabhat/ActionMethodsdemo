using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionMethodsdemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public string Show()
        {
            return "This is the a second action method of Home Controller";
        } 
        public ActionResult AboutUs()
        {
            return View();
        }

        public int StudentID(int id)
        {
            return id;
        }
    }
}