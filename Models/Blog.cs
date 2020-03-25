

using System.Collections.Generic;

namespace tmpmvc.Models
{
    public class BlogList
    {
        public BlogList()
        {
            Articles = new List<Article>();
        }
        public List<Article> Articles { get; set; }
    }
    public class Article
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}