using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        /*
         Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. If there are no elements left in the list, print "empty".
         

        Input                   Output
        10 -5 7 9 -33 50        50 9 7 10

        7 -2 -10 1               1 7

        -1 -2 -3                empty
         */
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> finalNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= 0)
                {
                    continue;
                }
                else
                {
                    finalNumbers.Add(numbers[i]);
                }
            }
            
            if (finalNumbers.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                finalNumbers.Reverse();
                Console.WriteLine(String.Join(" ", finalNumbers));
            }
        }
    }
}
