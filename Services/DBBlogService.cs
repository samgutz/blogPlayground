using tmpmvc.Models;
using System;

namespace tmpmvc.Services
{
    public class DBBlogService : IBlogService
    {
        public BlogList _blogList;
        public DBBlogService()
        {
            _blogList = new BlogList();
        }

        public bool CreateArticle(Article article)
        {
            _blogList.Articles.Add(article.ArticleId, article);
            return true;
        }

        public bool DeleteArticle()
        {
            throw new NotImplementedException();
        }

        public Article ReadArticle(Guid articleId)
        {
            return _blogList.Articles[articleId];
        }

        public bool UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
        public BlogList GetAllBlogs()
        {
            return _blogList;
        }
    }
}