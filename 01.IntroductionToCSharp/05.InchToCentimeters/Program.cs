using System;

namespace _05.InchToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 inch 2.54

            Console.Write("Inch: ");
            int inch = int.Parse(Console.ReadLine());
            double oneInchInCentimeters = 2.54;

            double sum = inch * oneInchInCentimeters;
            Console.Write("Centimeters: ");
            Console.WriteLine(sum);
        }
    }
}
