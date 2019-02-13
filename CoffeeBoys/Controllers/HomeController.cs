using CoffeeBoys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeBoys.Controllers
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
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult AddUser(User u)
        {
            ViewBag.FirstName = u.FirstName;
            ViewBag.Password = u.Password;
            ViewBag.PhoneNumb = u.PhoneNumb;
            ViewBag.Email = u.Email;
            ViewBag.LastName = u.LastName;
            return View();
        }
    }
}