using System;

namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        /*
         Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:

        Create a method called GetMultipleOfEvenAndOdds()
        Create a method GetSumOfEvenDigits()
        Create GetSumOfOddDigits()
        You may need to use Math.Abs() for negative numbers

        Input               Output                  Comment

        -12345              54                      Evens: 2 4
                                                    Odds: 1 3 5
                                                    Even sum: 6
                                                    Odd sum: 9
                                                    6 * 9 = 54
         */
        static void Main(string[] args)
        {
            int evenOddNumbers = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(evenOddNumbers);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvenAndOdds(int evenOddNumbers)
        {
            string evenOddNumbersString = evenOddNumbers.ToString();
            int[] evenOddNumbersArray = new int[evenOddNumbersString.Length];

            for (int i = 0; i < evenOddNumbersString.Length; i++)
            {
                evenOddNumbersArray[i] = evenOddNumbersString[i] - '0';
            }

            int evenDigitsSum = GetSumOfEvenDigits(evenOddNumbersArray);

            int oddDigitsSum = GetSumOfOddDigits(evenOddNumbersArray);

            return evenDigitsSum * oddDigitsSum;
        }

        private static int GetSumOfEvenDigits(int[] evenOddNumbersArray)
        {
            int sum = 0;

            for (int i = 0; i < evenOddNumbersArray.Length; i++)
            {
                if (evenOddNumbersArray[i] % 2 == 0) 
                {
                    sum += evenOddNumbersArray[i];
                }
            }

            return sum;
        }

        private static int GetSumOfOddDigits(int[] evenOddNumbersArray)
        {
            int sum = 0;

            for (int i = 0; i < evenOddNumbersArray.Length; i++)
            {
                if (evenOddNumbersArray[i] % 2 == 1) 
                {
                    sum += evenOddNumbersArray[i]; 
                }
            }

            return sum;
        }
    }
}
