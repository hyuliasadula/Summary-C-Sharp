using System;

namespace _07.FruitShop
{
    internal class Program
    {
        /*
         Магазин за плодове през работните дни работи на следните цени:
            плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
            цена	2.50	1.20	0.85	1.45	2.70	5.50	3.85

        Събота и неделя магазинът работи на по-високи цени:
            плод	banana	apple	orange	grapefruit	kiwi	pineapple	grapes
            цена	2.70	1.25	0.90	1.60	3.00	5.60	4.20

        Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes), ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество (реално число) , въведени от потребителя, и пресмята цената според цените от таблиците по-горе. Резултатът да се отпечата закръглен с 2 цифри след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата "error". 

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit name(banana / apple / orange / grapefruit / kiwi / pineapple / grapes): ");
            string fruitName = Console.ReadLine();

            Console.WriteLine("Day of the week: ");
            string dayOfTheWeek = Console.ReadLine();

            Console.WriteLine("Quantity of the product: ");
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            switch (dayOfTheWeek)
            {
                case "Monday"://2.50	1.20	0.85	1.45	2.70	5.50	3.85
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruitName)
                    {
                        case "banana":
                            price = 2.5;
                            price *= quantity;
                            break;
                        case "apple":
                            price = 1.2;
                            price *= quantity;
                            break;
                        case "orange":
                            price = 0.85;
                            price *= quantity;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            price *= quantity;
                            break;
                        case "kiwi":
                            price = 2.7;
                            price *= quantity;
                            break;
                        case "pineaple":
                            price = 5.5;
                            price *= quantity;
                            break;
                        case "grapes":
                            price = 3.85;
                            price *= quantity;
                            break;
                    }
                    break;
                case "Saturday"://2.70	1.25	0.90	1.60	3.00	5.60	4.20
                case "Sunday":
                    switch (fruitName)
                    {
                        case "banana":
                            price = 2.7;
                            price *= quantity;
                            break;
                        case "apple":
                            price = 1.25;
                            price *= quantity;
                            break;
                        case "orange":
                            price = 0.90;
                            price *= quantity;
                            break;
                        case "grapefruit":
                            price = 1.60;
                            price *= quantity;
                            break;
                        case "kiwi":
                            price = 3;
                            price *= quantity;
                            break;
                        case "pineaple":
                            price = 5.6;
                            price *= quantity;
                            break;
                        case "grapes":
                            price = 4.2;
                            price *= quantity;
                            break;
                    }
                    break;
            }
            Console.WriteLine($"The total price of the{fruitName} of {price:f2} lv.");
        }
    }
}
