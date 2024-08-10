using System;

namespace _05.MaxNumber
{
    internal class Program
    {
        /*
         Напишете програма, която до получаване на командата "Stop", чете цели числа, въведени от потребителя и намира най-голямото измежду тях. Въвежда се по едно число на ред. 
         */
        static void Main(string[] args)
        {

            int maxNumber = int.MinValue;
            string input = Console.ReadLine();

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number > maxNumber)
                {
                    maxNumber = number;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine($"Max number: {maxNumber}");
        }

    }
    
}
