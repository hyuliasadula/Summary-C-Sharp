using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace _08.Articles
{
    internal class Program
    {
        /*
         Create a class Article with the following properties:
        Title – a string
        Content – a string
        Author – a string
        The class should have a constructor and the following methods:
        Edit (new content) – change the old content with the new one
        ChangeAuthor (new author) – change the author
        Rename (new title) – change the title of the article
        Override the ToString method – print the article in the following format:
        "{title} - {content}: {author}"

        Create a program that reads an article in the following format "{title}, {content}, {author}". On the next line, you will receive a number n, representing the number of commands, which will follow after it. On the next n lines, you will be receiving the following commands:
        "Edit: {new content}"
        "ChangeAuthor: {new author}"
        "Rename: {new title}"
        In the end, print the final state of the article.


Input 
Fight club, love story, Martin Scorsese
2
Edit: underground fight club that evolves into much more
ChangeAuthor: Chuck Palahniuk 
        
Output
Fight club - underground fight club that evolves into much more: Chuck Palahniuk
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Type an article in the following format \"{title}, {content}, {author}\":");
            string[] articleDetails = Console.ReadLine().Split(',').Select(part => part.Trim()).ToArray();

            string title = articleDetails[0];
            string content = articleDetails[1];
            string author = articleDetails[2];

            //Article instance
            Article article = new Article(title, content, author);

            Console.WriteLine("Enter the number of commands:");
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("Edit:"))
                {
                    string newContent = command.Substring(5).Trim();
                    article.Edit(newContent);
                }
                else if (command.StartsWith("ChangeAuthor:"))
                {
                    string newAuthor = command.Substring(13).Trim();
                    article.ChangeAuthor(newAuthor);
                }
                else if (command.StartsWith("Rename:"))
                {
                    string newTitle = command.Substring(7).Trim();
                    article.Rename(newTitle);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}