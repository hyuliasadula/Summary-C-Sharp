using System;

namespace _09.EvenOddNumbersSum
{
    internal class Program
    {
        /*
         Да се напише програма, която чете n-на брой цели числа, подадени от потребителя и проверява дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции. 
        •	Ако сумите са равни да се отпечатат два реда: "Yes" и на нов ред "Sum = " + сумата; 
        •	Ако сумите не са равни да се отпечат два реда: "No" и на нов ред "Diff = " + разликата. 
        Разликата се изчислява по абсолютна стойност. 

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number for n-times a number: ");
            int n = int.Parse(Console.ReadLine());
            int numbers = 0;
            int evenNumbers = 0;
            int oddNumbers = 0;

            int evenNumSum = 0;
            int oddNumSum = 0;

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenNumSum += numbers;
                }
                else
                {
                    oddNumSum+= numbers;
                }
            }
            if (oddNumSum == evenNumSum)
            {
                Console.WriteLine($"Yes, sum = {evenNumSum}");
            }
            else
            {
                int absolute = Math.Abs(evenNumSum - oddNumSum);
                Console.WriteLine($"No, diff = {absolute}");
            }
        }
    }
}
