using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tmpmvc.Models;
using tmpmvc.Services;

namespace tmpmvc.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost]
        public IActionResult AddBlog([FromForm]Article article)
        {
            _blogService.CreateArticle(article);
            return View("Views/Blog/BlogSaveConfirmation.cshtml", article);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllBlogs()
        {
            var allBlogs = _blogService.GetAllBlogs();
            return View(allBlogs);
        }

        [Route("Blog/ViewArticle/{artcleId}")]
        public IActionResult ViewArticle(Guid artcleId)
        {
            var article = _blogService.ReadArticle(artcleId);
            return View(article);
        }


        [HttpGet]
        [Route("Blog/EditArticle/{artcleId}")]
        public IActionResult EditArticle(Guid artcleId)
        {
            var article = _blogService.ReadArticle(artcleId);
            return View(article);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
