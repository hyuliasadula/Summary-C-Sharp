using System;
using System.Linq;

namespace _13.MagicSum
{
    internal class Program
    {
        /*
         Create a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.
         
        Input	                Output
        1 7 6 2 19 23
        8	                     1 7
                                 6 2

        14 20 60 13 7 19 8
        27	                     14 13
                                 20 7
                                 19 8
         
         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                //j = i + 1 ->  to avoid duplicates
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currentNumber + numbers[j] == result)
                    {
                        
                        Console.WriteLine(currentNumber + " " + numbers[j]);
                    }
                }
            }
        }
    }
}
