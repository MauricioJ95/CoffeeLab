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
            ViewBag.CurrentUser = (User)Session["CurrentUser"];
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
        public ActionResult UserDetails(User newUser)
        {
            //add sessions
            if (Session["CurrentUser"] != null)
            {
                newUser = (User)Session["CurrentUser"];
                ViewBag.CurrentUser = newUser;
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    ViewBag.CurrentUser = newUser;
                    Session["CurrentUser"] = newUser;
                    return View();
                }
                else
                {
                    ViewBag.ErrorMessage = "Registration failed. Try again.";
                    return View("Error");
                }
            }
        }
        public ActionResult LogOut()
        {
            Session.Remove("CurrentUser");
            return RedirectToAction("Index");
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