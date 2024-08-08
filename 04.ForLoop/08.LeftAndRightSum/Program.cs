using System;

namespace _08.LeftAndRightSum
{
    internal class Program
    {
        /*
         Да се напише програма, която чете 2*n-на брой цели числа, подадени от потребителя, и проверява дали сумата на първите n числа (лява сума) е равна на сумата на вторите n числа (дясна сума). При равенство печата " Yes, sum = " + сумата; иначе печата " No, diff = " + разликата. Разликата се изчислява като положително число (по абсолютна стойност). 
         
         */
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int leftNumber = 0;
            int rightNumber = 0;

            int leftSum = 0;
            int rightSum = 0;

            Console.WriteLine();
            for (int left = 1; left <= number; left++)
            {
                leftNumber = int.Parse(Console.ReadLine());
                leftSum += leftNumber;
            }
            Console.WriteLine();
            for (int right = 1; right <= number; right++)
            {
                rightNumber = int.Parse(Console.ReadLine());
                rightSum+= rightNumber;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int absolute = Math.Abs(leftSum- rightSum);
                Console.WriteLine($"No, diff = {absolute}");
            }

        }
    }
}
