using System;

namespace _05.WorkingHours
{
    internal class Program
    {
        /*
         Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) - въведени от потребителя и проверява дали офисът на фирма е отворен, като работното време на офисът е от 10-18 часа, от понеделник до събота включително
         */
        static void Main(string[] args)
        {
            //working hours 10-18
            Console.Write("Time of the day(0-24): ");
            int timeOfTheDay = int.Parse(Console.ReadLine());

            Console.Write("Day of the week: ");
            string dayOfTheWeek = Console.ReadLine();

            if (dayOfTheWeek == "Sunday")
            {
                Console.WriteLine("Closed");
            }
            else
            {
                if (timeOfTheDay <= 18 && timeOfTheDay >= 10)
                {
                    Console.WriteLine("Open");
                }
                else
                {
                    Console.WriteLine("Closed");
                }
            }
        }
    }
}
