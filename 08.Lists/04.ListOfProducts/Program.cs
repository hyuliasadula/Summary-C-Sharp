using System;
using System.Collections.Generic;

namespace _04.ListOfProducts
{
    internal class Program
    {
        /*
         Read a number n and n lines of products. Print a numbered list of all the products ordered by name.

        Input                       Output

            4                       1.Apples
            Potatoes                2.Onions
            Tomatoes                3.Potatoes
            Onions                  4.Tomatoes
            Apples 
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("How many lines of product? ");
            int linesOfProducts = int.Parse(Console.ReadLine());
            List<string> products= new List<string>();

            for (int i = 0; i < linesOfProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                
                    Console.WriteLine($"{i + 1}. {products[i]}");
                
            }
        }
    }
}
