using System;

namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        //Create a method that calculates and returns the area of a rectangle.
        static void Main(string[] args)
        {
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: ");
            int result =RectangleAreaCalculation(width ,height);
            Console.WriteLine(result);
        }

        private static int RectangleAreaCalculation(int width , int height)
        {
            return width * height;
        }
    }
}
