using System;

namespace _12.Coins
{
    internal class Program
    {
        /*
        Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто. Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.
        */
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());

            int changeCount = 0;

            change = Math.Round(change, 2);

            while (change > 0)
            {
                if (change >= 2.00)
                {
                    change -= 2.00;
                    changeCount++;
                }
                else if (change >= 1.00)
                {
                    change -= 1.00;
                    changeCount++;
                }
                else if (change >= 0.50)
                {
                    change -= 0.50;
                    changeCount++;
                }
                else if (change >= 0.20)
                {
                    change -= 0.20;
                    changeCount++;
                }
                else if (change >= 0.10)
                {
                    change -= 0.10;
                    changeCount++;
                }
                else if (change >= 0.05)
                {
                    change -= 0.05;
                    changeCount++;
                }
                else if (change >= 0.02)
                {
                    change -= 0.02;
                    changeCount++;
                }
                else
                {
                    change -= 0.01;
                    changeCount++;
                }
                // To keep the calculations accurate
                change = Math.Round(change, 2);
            }

            Console.WriteLine(changeCount);
        }
    }
}
