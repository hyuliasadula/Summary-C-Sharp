using System;

namespace _02.StatementsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grades
            /*
             Kонзолна програма, която чете оценка (дробно число), въведена от потребителя и отпечатва "Excellent!", ако оценката е 5.50 или по-висока.
             */

            Console.Write("Type student grade here: ");
            double studentGrade = double.Parse(Console.ReadLine());

            if (studentGrade > 5.5)
            {
                Console.WriteLine("Excellent!");
            }

        }
    }
}
