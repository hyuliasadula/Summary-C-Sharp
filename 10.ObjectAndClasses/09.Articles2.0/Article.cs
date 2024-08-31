using System;
using System.Collections.Generic;
using System.Text;

namespace _09.Articles2._0
{
    internal class Article
    {
        // Properties for the article
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        // Constructor to initialize the article
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
