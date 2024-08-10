using System;

namespace _04.AccountBalance
{
    internal class Program
    {
        /*
         Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой вноски. На всеки ред ще получавате сумата, която трябва да внесете в сметката, до получаване на команда "NoMoreMoney" . При всяка получена сума на конзолата трябва да се извежда "Increase: " + сумата и тя да се прибавя в сметката. Ако получите число по-малко от 0 на конзолата трябва да се изведе "Invalid operation!" и програмата да приключи. Когато програмата приключи трябва да се принтира "Total: " + общата сума в сметката форматирана до втория знак след десетичната запетая. 
        Input                       Output
        5.51                        Increase: 5.51
        69.42                       Increase: 69.42
        100                         Increase: 100.00
        NoMoreMoney	                Total: 174.93
        
         */
        static void Main(string[] args)
        {

            string money = "";
            double inputToNumber = 0.0;
            double sum = 0.0;

            while (true)
            {
                money = Console.ReadLine();
                if (money == "NoMoreMoney")
                {
                    break;
                }
                inputToNumber = double.Parse(money);
                if (inputToNumber < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += inputToNumber;
                Console.WriteLine($"Increase: {inputToNumber}");

            }

            Console.WriteLine($"Total: {sum}");

        }
    }
}
