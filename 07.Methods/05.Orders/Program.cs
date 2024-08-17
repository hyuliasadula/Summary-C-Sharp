using System;

namespace _05.Orders
{
    internal class Program
    {
        /*
         Create a program that calculates and prints the total price of an order. The method should receive two parameters:

        · A string, representing a product - "coffee", "water", "coke", "snacks"
        · An integer, representing the quantity of the product

        The prices for a single item of each product are:
        coffee – 1.50
        water – 1.00
        coke – 1.40
        snacks – 2.00
        Print the result, rounded to the second decimal place.
         
        Input       Output
        water
        5               5.00

        coffee
        2               3.00
         */
        static void Main(string[] args)
        {
            

            Console.WriteLine("Product name (\"coffee\", \"water\", \"coke\", \"snacks\"): ");
            string product = Console.ReadLine();

            Console.WriteLine("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            ProductsPrice(product, quantity);
        }

        private static void ProductsPrice( string product, int quantity)
        {
            double coffee = 1.5;
            double water = 1.0;
            double coke = 1.4;
            double snacks = 2.0;
            if (product == "coffee")
            {
                Console.WriteLine($"{(quantity * coffee):f2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{(quantity * water):f2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{(quantity * snacks):f2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{(quantity * coke):f2}");
            }
        }
    }
}
