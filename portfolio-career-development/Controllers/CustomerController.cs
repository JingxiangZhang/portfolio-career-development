using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portfolio_career_development.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrivateLesson()
        {
            return View();
        }

        public ActionResult FoodRecommendation()
        {
            return View();
        }

        public ActionResult GymBooking()
        {
            return View();
        }

        public ActionResult CustomerInfo()
        {
            return RedirectToAction("Index","Manage");
        }
    }
}