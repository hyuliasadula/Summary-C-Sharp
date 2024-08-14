using System;
using System.Linq;

namespace _09.CommonElements
{
    internal class Program
    {
        /*
         Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.
         
                 Input	                Output
                Hey hello 2 4
                10 hey 4 hello	        4 hello


                S of t un i
                of i 10 un	            of i un

                i love to code
                code i love to	       code i love to

         */
        static void Main(string[] args)
        {
            Console.WriteLine("First array: ");
            string[] firstArr = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine("Second array: ");
            string[] secondArr = Console.ReadLine().Split(' ').ToArray();


            for (int second = 0; second < secondArr.Length; second++)
            {
                string currentStr = secondArr[second];
                for (int first = 0; first < firstArr.Length; first++)
                {
                    if (currentStr == firstArr[first])
                    {
                        
                        Console.Write(secondArr[second] + " ");
                    }
                }
            }
        }
    }
}