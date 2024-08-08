using System;

namespace _03.NumbersWith3Steps
{
    internal class Program
    {
        //Напишете програма, която чете число n, въведено от потребителя и отпечатва числата от 1 до n през 3.
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
