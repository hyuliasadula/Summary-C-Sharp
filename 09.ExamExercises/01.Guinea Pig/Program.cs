using System;

namespace _01.Guinea_Pig
{
    internal class Program
    {
        /*
         On the first three lines, you will receive the quantity of food, hay and cover, which Merry buys for a month (30 days). On the fourth line, you will receive the guinea pig's weight.

        Every day Puppy eats 300 gr of food. Every second day Merry first feeds the pet, then gives it a certain amount of hay equal to 5% of the rest of the food. On every third day,Merry puts Puppy cover with a quantity of 1/3 of its weight.

        Calculate whether the quantity of food, hay and cover will be enough for a month.

            If Merry runs out of food, hay, or cover, stop the program!

            Input

            · On the first line – quantity food in kilograms - a floating-point number in the range [.0…10000.0].
            · On the second line – quantity hay in kilograms - a floating-point number in the range [.0…10000.0].
            · On the third line – quantity cover in kilograms - a floating-point number in the range [.0…10000.0].
            · On the fourth line – guinea's weight in kilograms - a floating-point number in the range [.0…10000.0].

                    Output

            If the food, the hay and the cover are enough, print:
            "Everything is fine! Puppy is happy! Food: {excessFood}, Hay: {excessHay}, Cover: {excessCover}."
            · If one of the things is not enough, print:
            o "Merry must go to the pet store!"
            The output values must be formatted to the second decimal place!
                     */
        static void Main(string[] args)
        {
            double foodQuantity = double.Parse(Console.ReadLine());
            double hayQuantity = double.Parse(Console.ReadLine());
            double coverQuantity = double.Parse(Console.ReadLine());
            double pigWeight = double.Parse(Console.ReadLine());

            double foodInGrams = foodQuantity * 1000;
            double hayInGrams = hayQuantity * 1000;
            double coverInGrams = coverQuantity * 1000;
            double pigWeightInGrams = pigWeight * 1000;

            int puppyEatsADay = 300;
            bool hasEnoughSupplies = true;

            for (int day = 1; day <= 30; day++)
            {
                foodInGrams -= puppyEatsADay;

                if (foodInGrams <= 0)
                {
                    hasEnoughSupplies = false;
                    break;
                }

                if (day % 2 == 0)
                {
                    hayInGrams -= foodInGrams * 0.05;

                    if (hayInGrams <= 0)
                    {
                        hasEnoughSupplies = false;
                        break;
                    }
                }

                if (day % 3 == 0)
                {
                    coverInGrams -= pigWeightInGrams / 3;

                    if (coverInGrams <= 0)
                    {
                        hasEnoughSupplies = false;
                        break;
                    }
                }
            }

            if (hasEnoughSupplies)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodInGrams / 1000):f2}, Hay: {(hayInGrams / 1000):f2}, Cover: {(coverInGrams / 1000):f2}.");
            }
            else
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}