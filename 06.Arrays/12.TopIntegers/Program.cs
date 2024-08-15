using System;
using System.Linq;

namespace _12.TopIntegers
{
    internal class Program
    {
        /*
         Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the elements to its right.
                Input	            Output
            1 4 3 2	                4 3 2
            14 24 3 19 15 17	    24 19 17
            27 19 42 2 13 45 48	    48
        */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currentNumber <= numbers[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                
                }
                if (isTopInteger)
                {
                    Console.Write(currentNumber + " ");
                }
            }

            Console.WriteLine();
        }
        
    }
}
