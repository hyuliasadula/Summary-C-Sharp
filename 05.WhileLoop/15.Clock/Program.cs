using System;

namespace _15.Clock
{
    internal class Program
    {
        /*
         Напишете програма, която отпечатва часовете в денонощието от 0:00 до 23:59, всеки на отделен ред. Часовете трябва да се изписват във формат "{час}:{минути}".
         */
        static void Main(string[] args)
        {
            int hours = 23;
            int minutes = 59;

            for (int h = 0; h <= hours; h++)
            {
                for (int m = 0; m <= minutes ; m++)
                {
                    if (m <10)
                    {
                        Console.WriteLine($"{h}:0{m}");
                    }
                    else
                    {
                        Console.WriteLine($"{h}:{m}");
                    }
                }
            }
        }
    }
}
