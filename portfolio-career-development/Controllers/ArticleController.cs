using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using portfolio_career_development.Models;

namespace portfolio_career_development.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            
            return View();
        }

        public ContentResult Edit(int id)
        {
            return Content("id = "+id);
        }

        
    }
}