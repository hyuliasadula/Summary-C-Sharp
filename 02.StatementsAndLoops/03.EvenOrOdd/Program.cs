using System;

namespace _03.EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 )
            {
                Console.WriteLine($"{number} is an Even Number!");
            }
            else
            {
                Console.WriteLine($"{number} is an Odd Number!");
            }
        }
    }
}
