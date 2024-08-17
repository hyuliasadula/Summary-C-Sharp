using System;

namespace _11.MathOperations
{
    internal class Program
    {
        /*
         Write a method that receives two numbers and an operator, calculates the result and returns it. You will be given three lines of input. The first will be the first number, the second one will be the operator and the last one will be the second number.

        The possible operators are: /, *, + and -.
         */
        static void Main(string[] args)
        {
            Console.Write("First number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Operation( /, *, -, + ): ");
            char operation = char.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            

            switch (operation)
            {
                case '/':
                    Divide(firstNum, secondNum);
                    break;
                case '*':
                    Multiply(firstNum, secondNum);
                    break;
                case '+':
                    Add(firstNum, secondNum);
                    break;
                case '-':
                    Subtract(firstNum, secondNum);
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
