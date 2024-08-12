using System;

namespace _16.MultiplicationTable
{
    internal class Program
    {
        /*
         Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат: 
        "{първи множител} * {втори множител} = {резултат}". 

         */
        static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 10;

            for (int first = 1; first <= firstNum ; first++)
            {
                for (int second = 1; second <= secondNum ; second++)
                {
                    Console.WriteLine($"{first} * {second} = {first * second}");
                }
            }
        }
    }
}
