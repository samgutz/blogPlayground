

using System.Collections.Generic;
using System;

namespace tmpmvc.Models
{
    public class BlogList
    {
        public BlogList()
        {
            Articles = new Dictionary<Guid, Article>();
        }
        public Dictionary<Guid, Article> Articles { get; set; }

    }
    public class Article
    {
        public Article()
        {
            ArticleId = Guid.NewGuid();
        }
        public Guid ArticleId {get;set;}
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}