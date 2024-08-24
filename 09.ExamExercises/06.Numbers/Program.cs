using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Numbers
{
    internal class Program
    {
        /*
         Write a program to read a sequence of integers and find and print the top 5 numbers greater than the average value in the sequence, sorted in descending order.
            Input
            •	Read from the console a single line holding space-separated integers.
            Output
            •	Print the above-described numbers on a single line, space-separated. 
            •	If less than 5 numbers hold the property mentioned above, print less than 5 numbers. 
            •	Print "No" if no numbers hold the above property.
            Constraints
            •	All input numbers are integers in the range [-1 000 000 … 1 000 000]. 
            •	The count of numbers is in the range [1…10 000].
            Examples

            Input	                    Output	            Comments
            10 20 30 40 50	            50 40	            Average number = 30.
                                                            Numbers greater than 30 are: {40, 50}. 
                                                            The top 5 numbers among them in descending order                                    are: {50, 40}.
                                                            Note that we have only 2 numbers, so all of them                                    are included in the top 5.

         */
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> copy = new List<int>();

            double average = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    copy.Add(numbers[i]);
                }
            }

            copy.Sort();
            copy.Reverse();

            if (copy.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", copy.Take(5)));
            }
        }
    }
}
