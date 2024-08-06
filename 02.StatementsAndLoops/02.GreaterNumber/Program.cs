using System;

namespace _02.GreaterNumber
{
    internal class Program
    {
        /*
         Да се напише програма, която чете две цели числа въведени от потребителя и отпечатва по-голямото от двете. 
         */
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is the bigger number");
            }
            else
            {
                Console.WriteLine($"{secondNumber} is the bigger number");
            }

        }
    }
}
