using System;

namespace _01.DaysOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = 
                { "Monday",
                  "Tuesday",
                  "Wednesday",
                  "Thursday",
                  "Friday",
                  "Saturday",
                  "Sunday"
            };

            Console.Write("Type a number (1-7): ");
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(days[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
