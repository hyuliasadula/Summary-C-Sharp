using System;

namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        /*
         * A single integer is given, create a method that checks if the given number is positive, negative, or zero. As a result print:

            For positive number: "The number {number} is positive. "

            For negative number: "The number {number} is negative. "

            For zero number: "The number {number} is zero. "

            Examples

            Input               Output

            2               The number 2 is positive.

            -9              The number -9 is negative.
         
         
         */
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PositiveOrNegativeNumber(number);
        }

        private static void PositiveOrNegativeNumber(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
    }
}
