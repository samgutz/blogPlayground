using tmpmvc.Models;
using System;

namespace tmpmvc.Services
{
    public interface IBlogService
    {
        bool CreateArticle(Article article);
        Article ReadArticle(Guid articleId);
        bool UpdateArticle(Article article);
        bool DeleteArticle();
        BlogList GetAllBlogs();
    }
}