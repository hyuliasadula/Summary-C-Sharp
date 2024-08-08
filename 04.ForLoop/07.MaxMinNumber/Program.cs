using System;

namespace _07.MaxMinNumber
{
    internal class Program
    {
        /*
         Напишете програма, която чете n на брой цели числа. Принтирайте най-голямото и най-малкото число сред въведените.
         
         */
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            int n = int.Parse(Console.ReadLine());
            int numbers = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            Console.WriteLine("Type the numbers: ");
            for (int i = 1; i <= n; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                if (numbers > max)
                {
                    max = numbers;
                }
                if (numbers < min && numbers <max)
                {
                    min = numbers;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);

        }
    }
}
