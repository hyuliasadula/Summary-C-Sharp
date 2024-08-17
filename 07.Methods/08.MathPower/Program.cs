using System;

namespace _08.MathPower
{
    internal class Program
    {
        /*
         Create a method, which receives two numbers as parameters:

        · The first number – the base
        · The second number – the power
        The method should return the base raised to the given power.

        Examples
        Input       Output
            2
            8           256

            3
            4           81
         */
        static void Main(string[] args)
        {
            Console.Write("Base number: ");
            double baseNum = double.Parse(Console.ReadLine());
            Console.Write("Power number: ");
            double powerNum = double.Parse(Console.ReadLine());
            Console.Write("Result: ");
            double result = MathPower(baseNum, powerNum);
            Console.WriteLine(result);
        }

        private static double MathPower(double baseNum, double powerNum)
        {
            return Math.Pow(baseNum, powerNum);
        }
    }
}
