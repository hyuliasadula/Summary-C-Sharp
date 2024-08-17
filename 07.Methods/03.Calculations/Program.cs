using System;
using System.ComponentModel;

namespace _03.Calculations
{
    internal class Program
    {
        /*
         Create a program that receives three lines of input:

        · On the first line – a string – "add", "multiply", "subtract", "divide".

        · On the second line – a number.

        · On the third line – another number.

        You should create four methods (for each calculation) and invoke the corresponding method depending on the command. The method should also print the result (needs to be void).
         
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Write an action (\"add\", \"multiply\", \"subtract\", \"divide\"): ");
            string action = Console.ReadLine();

            Console.WriteLine("Fisrt Number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: ");
            switch (action)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }
        }

        private static void Divide(int firstNumber, int secondNumber)
        {
            if (firstNumber != 0 && secondNumber != 0)
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
            else
            {
                Console.WriteLine("Can't divide by 0");
            }
            
        }

        private static void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }

        private static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        private static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }

    }
}
