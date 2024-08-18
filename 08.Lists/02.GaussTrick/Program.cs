using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    internal class Program
    {
        /*
         Create a program that sums all numbers in a list in the following order:
              first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

        Input           Output
        1 2 3 4 5       6 6 3

        1 2 3 4          5 5
         
         */
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            GaussTrick(numbers, result);
           
        }

        private static void GaussTrick(List<int> numbers, List<int> result)
        {
            while (numbers.Count > 0)
            {
                // Only one element left
                if (numbers.Count == 1)
                {
                    result.Add(numbers[0]);
                    break;
                }

                int sum = numbers[0] + numbers[numbers.Count - 1];
                result.Add(sum);

                numbers.RemoveAt(0);
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
