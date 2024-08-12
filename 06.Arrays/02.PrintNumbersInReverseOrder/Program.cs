using System;

namespace _02.PrintNumbersInReverseOrder
{
    internal class Program
    {
        /*
            Read n numbers and print them in reverse order, separated by a single space.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to type in the array? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();


            int[] arr = new int[n];
            Console.WriteLine("Type numbers: ");


            for (int i = 0; i < n; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Result: ");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i] + " ");
                
            }


        }
    }
}
