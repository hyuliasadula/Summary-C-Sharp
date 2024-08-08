using System;

namespace _05.SumNumbers
{
    internal class Program
    {
        /*
         Да се напише програма, която чете n-на брой цели числа, въведени от потребителя и ги сумира.
        •	От първия ред на входа се въвежда броят числа n.
        •	От следващите n реда се въвежда по едно цяло число.
        Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им. 

         */
        static void Main(string[] args)
        {
            Console.Write("How many numbers: ");
            int n = int.Parse(Console.ReadLine());
            int numbers = 0;
            int sum = 0;
            Console.WriteLine("Type the numbers: ");
            for (int i = 1; i <= n; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                sum += numbers;
            }
            Console.Write("The result is: ");
            Console.WriteLine(sum);
        }
    }
}
