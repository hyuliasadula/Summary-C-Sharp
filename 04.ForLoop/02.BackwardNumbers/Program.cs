using System;

namespace _02.BackwardNumbers
{
    internal class Program
    {
        /*
         Напишете програма, която чете цяло положително число n, въведено от потребителя и печата числата от n до 1 в обратен ред. Въведеното число n, винаги ще бъде по-голямо от 1.
         */
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
