using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ComputerStore
{
    internal class Program
    {
        /*
         Write a program that prints you a receipt for your new computer. You will receive the parts' prices (without tax) until you receive what type of customer this is - special or regular. Once you receive the type of customer you should print the receipt.

        The taxes are 20% of each part's price you receive.
        If the customer is special, he has a 10% discount on the total price with taxes.
        If a given price is not a positive number, you should print "Invalid price!" on the console and continue with the next price.
        If the total price is equal to zero, you should print "Invalid order!" on the console.
        Input
        · You will receive numbers representing prices (without tax) until command "special" or "regular":
        Output
        · The receipt should be in the following format:
        "Congratulations you've just bought a new computer!
        Price without taxes: {total price without taxes}$
        Taxes: {total amount of taxes}$

        -----------

        Total price: {total price with taxes}$"

        Note: All prices should be displayed to the second digit after the decimal point! The discount is applied only to the total price. Discount is only applicable to the final price!


        Input                                   Output

            1050                            Congratulations you've just bought a new computer!
            200                             Price without taxes: 1737.36$
            450                             Taxes: 347.47$
            2                               -----------
            18.50                           Total price: 1876.35$
            16.86
            special     
         
         */
        static void Main(string[] args)
        {
            List<double> prices = new List<double>();

            string input;
            double sum = 0d;
            while ((input = Console.ReadLine()) != "regular" && input != "special")
            {
                
                double currentPrice = double.Parse(input);
                if (currentPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else  
                {
                    sum += currentPrice;
                    prices.Add(currentPrice);
                }
                
            }
            double tax = 0.2; //20%
            double taxes = sum * tax;
            OutputText(tax, taxes, sum, input);
            
        }

        private static void OutputText( double tax, double taxes,  double sum, string input)
        {
            if (sum == 0)
            {
                Console.WriteLine("Invalid order!");

            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}");
                Console.WriteLine($"Taxes: {taxes:f2}");
                Console.WriteLine("-----------");
                if (input == "special")
                {
                    double discount = (sum + taxes) * 0.9;
                    Console.WriteLine($"Total price: {discount:f2}$");
                }
                else if (input == "regular")
                {
                    Console.WriteLine($"Total price: {sum + taxes:f2}$");
                }
            }
            
            


        }
    }
}
