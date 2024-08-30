using System;

namespace _08.Articles
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

        // Method to change the content of the article
        public void Edit(string newContent)
        {
            Content = newContent;
        }

        // Method to change the author of the article
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        // Method to change the title of the article
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        // Overriding ToString to return the article in the specified format
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
