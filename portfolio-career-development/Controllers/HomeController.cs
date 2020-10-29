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
        public ActionResult Index()
        {

            var articles = GetArticles();

            return View(articles);
        }


        public ActionResult Contact()
        {
            
            return View();
        }

        public ActionResult Details(int id)
        {
            var article = GetArticles().SingleOrDefault(a => a.id == id);

            if (article == null)
                return HttpNotFound();

            return View(article);
        }

        private IEnumerable<Article> GetArticles()
        {
            return new List<Article>
            {
                new Article() { id = 1, title = "Title 1", content = "Content 1" },
                new Article() { id = 2, title = "Title 2", content = "Content 2" },
                new Article() { id = 3, title = "Title 3", content = "Content 3" },
                new Article() { id = 4, title = "Title 4", content = "Content 4" }
            };
        }
    }
}