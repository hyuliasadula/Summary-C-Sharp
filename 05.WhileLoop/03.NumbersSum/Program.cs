using System;

namespace _03.NumbersSum
{
    internal class Program
    {
        /*
         Напишете програма, която чете цяло число от конзолата и на всеки следващ ред цели числа, докато тяхната сума стане по-голяма или равна на първоначалното число. След приключване да се отпечата сумата на въведените числа.
         */
        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            int number = int.Parse(Console.ReadLine());
            int newNumbers = 0;
            int sumNumbers = 0;

            Console.WriteLine();
            Console.WriteLine("Type the numbers: ");
            while (number > sumNumbers) 
            {
                newNumbers = int.Parse(Console.ReadLine());
                sumNumbers += newNumbers;
            }
            Console.WriteLine(sumNumbers);


        }
    }
}
