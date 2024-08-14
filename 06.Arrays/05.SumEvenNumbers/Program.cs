using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    internal class Program
    {
        /*
         Read an array from the console and sum only its even values.

                    Examples

                    Input                   Output

                    1 2 3 4 5 6                 12

                    3 5 7 9                     0

                    2 4 6 8 10                  30
         
         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int sumEvenNum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEvenNum += numbers[i];
                }
            }
            Console.WriteLine(sumEvenNum);
        }
    }
}
