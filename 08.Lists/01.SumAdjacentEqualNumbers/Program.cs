using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        /*
         Create a program to sum all of the adjacent equal numbers in a list of decimal numbers, starting from left to right.

        · After two numbers are summed, the result could be equal to some of its neighbors and should be summed as well (see the examples below)

        · Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available)
         



  input Output Explanation

3 3 6 1                 12 1                    3 3 6 1 -> 6 6 1 -> 12 1

8 2 2 4 8 16            16 8 16                 8 2 2 4 8 16 -> 8 4 4 8 16 -> 8 8 8 16 -> 16 8 16

5 4 2 1 1 4             5 8 4                   5 4 2 1 1 4 -> 5 4 2 2 4 -> 5 4 4 4 -> 5 8 4
         */
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            ResultCalculations(input);
        }

        private static void ResultCalculations(List<int> input)
        {
            int i = 0;
            while (i < input.Count - 1)
            {
                if (input[i] == input[i + 1])
                {
                    //Sum the equals
                    int sum = input[i] + input[i + 1];

                    // To replace the number with the sum
                    input[i] = sum;

                    // To remove the second number from the list
                    input.RemoveAt(i + 1);

                    // To start over
                    i = 0;
                }
                else
                {
                    //++ to move to the next pair
                    i++;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}