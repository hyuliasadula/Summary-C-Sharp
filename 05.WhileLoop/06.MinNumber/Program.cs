using System;

namespace _06.MinNumber
{
    internal class Program
    {
        /*
         Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-малкото измежду тях. Въвежда се по едно число на ред. 
         
         */
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number < minNumber)
                {
                    minNumber = number;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
