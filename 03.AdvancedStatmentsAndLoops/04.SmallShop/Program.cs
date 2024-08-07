using System;

namespace _04.SmallShop
{
    internal class Program
    {
        /*
         Предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени според града:
град / продукт	coffee	water	beer	sweets	peanuts
        Sofia	0.50	0.80	1.20	1.45	1.60
        Plovdiv	0.40	0.70	1.15	1.30	1.50
        Varna	0.45	0.70	1.10	1.35	1.55
Напишете програма, която чете продукт (низ), град (низ) и количество (десетично число), въведени от потребителя, и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град. 

         */
        static void Main(string[] args)
        {
            Console.Write("Product: ");
            string productName= Console.ReadLine();

            Console.Write("City: ");
            string cityName = Console.ReadLine();

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            switch (cityName)
            {
                case "Sofia":
                    switch (productName)
                    {
                        case "coffee":
                            price = 0.5;
                            price *= quantity;
                            break;
                        case "water":
                            price = 0.8;
                            price *= quantity;
                            break;
                        case "beer":
                            price = 1.2;
                            price *= quantity;
                            break;
                        case "sweets":
                            price = 1.45;
                            price *= quantity;
                            break;
                        case "peanuts":
                            price= 1.6;
                            price *= quantity;
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (productName)
                    {
                        case "coffee":
                            price = 0.4;
                            price *= quantity;
                            break;
                        case "water":
                            price = 0.7;
                            price *= quantity;
                            break;
                        case "beer":
                            price = 1.15;
                            price *= quantity;
                            break;
                        case "sweets":
                            price = 1.30;
                            price *= quantity;
                            break;
                        case "peanuts":
                            price = 1.5;
                            price *= quantity;
                            break;
                    }
                    break;
                case "Varna":
                    switch (productName)
                    {
                        case "coffee":
                            price = 0.4;
                            price *= quantity;
                            break;
                        case "water":
                            price = 0.7;
                            price *= quantity;
                            break;
                        case "beer":
                            price = 1.1;
                            price *= quantity;
                            break;
                        case "sweets":
                            price = 1.35;
                            price *= quantity;
                            break;
                        case "peanuts":
                            price = 1.55;
                            price *= quantity;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"We dont have the shop in {cityName}");
                    break;
            }
            Console.WriteLine($"The total for the {productName} is {price}lv.");
        }
    }
}
