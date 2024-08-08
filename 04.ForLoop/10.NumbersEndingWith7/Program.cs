using System;

namespace _10.NumbersEndingWith7
{
    internal class Program
    {
        //Напишете програма, която отпечатва числата в диапазона от 1 до 1000, които завършват на 7.
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 10== 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
