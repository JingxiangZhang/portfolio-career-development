using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using portfolio_career_development.Models;
using portfolio_career_development.ViewModels;

namespace portfolio_career_development.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {

            return View();
        }


        public ViewResult Contact()
        {
            
            return View();
        }
    }
}