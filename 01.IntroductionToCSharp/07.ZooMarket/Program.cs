using System;

namespace _07.ZooMarket
{
    internal class Program
    {
        /*
         Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета и котки.  Храната се пазарува от зоомагазин, като една опаковка храна за кучета е на цена 2.50 лв, а опаковка храна за котки струва 4 лв.
         */
        static void Main(string[] args)
        {
            Console.Write("How many dog food you'll buy? ");
            int dogFoodCount = int.Parse(Console.ReadLine());
            Console.Write("How many cat food you'll buy? ");
            int catFoodCount = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.5;
            int catFoodPrice = 4;

            double sum = (catFoodCount * catFoodPrice) + (dogFoodCount * dogFoodPrice);
            Console.WriteLine($"{sum} lv.");
        }
    }
}
