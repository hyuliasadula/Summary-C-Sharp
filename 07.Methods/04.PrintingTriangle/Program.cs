using System;

namespace _04.PrintingTriangle
{
    internal class Program
    {
        /*
         Create a method for printing triangles as shown below:

        Examples

        Input           Output

        3               1
                        1 2
                        1 2 3
                        1 2
                        1
         
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number!");
            int number = int.Parse(Console.ReadLine());
            PrintingTriangle(number);
        }

        private static void PrintingTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
            for (int i = number ; i >= 1; i--)
            {
                for (int y = 1; y <= i - 1; y++)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
