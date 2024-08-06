﻿using System;

namespace _06.SpeedInformation
{
    internal class Program
    {
        /*
         Да се напише програма, която чете скорост (реално число), въведена от потребителя и отпечатва информация за скоростта. 
            •	При скорост до 10 (включително) отпечатайте "slow"
            •	При скорост над 10 и до 50 (включително) отпечатайте "average" 
            •	При скорост над 50 и до 150 (включително) отпечатайте "fast"
            •	При скорост над 150 и до 1000 (включително) отпечатайте "ultra fast" 
            •	При по-висока скорост отпечатайте "extremely fast"

         */
        static void Main(string[] args)
        {
            Console.Write("Type the speed: ");
            int speed = int.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed >150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }

        }
    }
}
