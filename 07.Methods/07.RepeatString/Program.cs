using System;

namespace _07.RepeatString
{
    internal class Program
    {
        /*
         Create a method that receives two parameters:

        · A string
        · A number n (integer) represents how many times the string will be repeated
        The method should return a new string, containing the initial one, repeated n times without space

        input               output
        abc
        3                   abcabcabc

        String
        2                   StringString
         */
        static void Main(string[] args)
        {
            Console.Write("Write your string here: ");
            string input = Console.ReadLine();

            Console.Write("Num of repeatment: ");
            int repeatedTimes = int.Parse(Console.ReadLine());

            Console.Write("Output: ");
            string output= RepeatingText(input, repeatedTimes);
            Console.WriteLine(output);
        }

        private static string RepeatingText(string input, int repeatedTimes)
        {
            while (repeatedTimes > 1)
            {
                Console.Write(input);
                repeatedTimes--;
            }
            return input;
        }
    }
}
