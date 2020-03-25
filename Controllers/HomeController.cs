using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tmpmvc.Models;

namespace tmpmvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var homeModel = new HomeModel
            {
                Name = "Sam"
            };
            return View(homeModel);
        }

        public IActionResult About()
        {
            var aboutModel = new AboutModel
            {
                Name = "Sam"
            };

            return View(aboutModel);
        }

        public IActionResult Blog()
        {
            var blogs = new BlogList();
            Article samArticle = new Article
            {
                Author = "Sam",
                Title = "My First Blog",
                Content = "This is some blog content"
            };

            Article imaArticle = new Article
            {
                Author = "Ima",
                Title = "My First Blog",
                Content = "This is some different blog content"
            };
            
            blogs.Articles.Add(samArticle);
            blogs.Articles.Add(imaArticle);
            return View(blogs);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
