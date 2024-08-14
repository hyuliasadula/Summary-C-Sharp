using System;
using System.Linq;

namespace _10.ZigZagArrays
{
    internal class Program
    {
        /*
         Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers. Form 2 new arrays in a zig-zag pattern as shown below.

        Input                   Output
        4                       1 10 31 20
        1 5                     5 9 81 41
        9 10
        31 81
        41 20	
        
        2
        80 23                   80 19
        31 19                   23 31	
        

         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //odd
            int[] firstArray = new int[n];
            //even
            int[] secondArray = new int[n];



            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


                if (i % 2 == 1)
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                else
                {
                    firstArray[i] = numbers[1];
                    secondArray[i] = numbers[0];
                }

            }
            Console.WriteLine("Odd: ");
            Console.WriteLine(string.Join(" ", secondArray));

            Console.WriteLine();

            Console.WriteLine("Even: ");
            Console.WriteLine(string.Join(" ", firstArray));
            
            

        }
    }
}
