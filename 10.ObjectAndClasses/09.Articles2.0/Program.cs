using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Articles2._0
{
    internal class Program
    {
        /*
         Change the program from the previous problem in such a way, that you will be able to store a list of articles. You will not need to use the previous methods anymore (except the "ToString()"). On the first line, you will receive the number of articles. On the next lines, you will receive the articles in the same format as in the previous problem: "{title}, {content}, {author}". Print the articles.

        Input 

2
Science, planets, Bill
Article, content, Johnny

        Output
Science - planets: Bill 
Article - content: Johnny
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Number of articles: ");
            int numOfArticles = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < numOfArticles; i++)
            {
                // To read and parse the article details
                //part => part.Trim() is a lambda expression that represents a function. This function takes each element (in this case, each string from the split operation) and applies the Trim() method to it.
                //Trim() removes any leading and trailing whitespace characters from each string element. This ensures that each part doesn't have extra spaces.
                string[] articleDetails = Console.ReadLine().Split(',').Select(part => part.Trim()).ToArray();

                string title = articleDetails[0];
                string content = articleDetails[1];
                string author = articleDetails[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }


        }
    }
}
