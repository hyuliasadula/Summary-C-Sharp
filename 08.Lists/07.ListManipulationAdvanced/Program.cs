using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        /*
         Next, we are going to implement more complicated list commands, extending the previous task. Again, read a list and keep reading commands until you receive "end":

        Contains {number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
        -PrintEven – print all the even numbers, separated by a space.
        -PrintOdd – print all the odd numbers, separated by a space.
        -GetSum – print the sum of all the numbers.
        -Filter {condition} {number} – print all the numbers that fulfill the given condition. The condition will be either '<', '>', ">=", "<=".
        -After the end command, print the list only if you have made some changes to the original list. Changes are made only from the commands from the previous task.

        Input                           Output
        5 34 678 67 5 563 98            No such number
        Contains 23                     5 67 5 563
        PrintOdd                        1450
        GetSum                          34 678 67 563 98
        Filter >= 21                    
        end 
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Type your integers with space between the numbers: ");
            List<int> integers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            Console.WriteLine("Write your command (Contains, PrintEven, PrintOdd, GetSum, Filter )");
            Console.WriteLine("If you type ( PrintOdd, GetSum, Filter ) make sure to leave space after the word");
            Console.WriteLine();
            while (true)
            {
                
                List<string> cmnd = Console.ReadLine().Split(" ").ToList();

                if (cmnd[0] == "end")
                {
                    break;
                }

                string command = cmnd[0];
                int number;
                string condition = cmnd[1];

                switch (command)
                {
                    case "Contains":
                        number = int.Parse(cmnd[1]);
                        integers.Contains(number);
                        if (integers.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        PrintEven(integers);
                        break;

                    case "PrintOdd":
                        PrintOdd(integers);
                        break;

                    case "GetSum":
                        Console.WriteLine(GetSum(integers));
                        break;
                    case "Filter":
                        List<int> filteredNumbers = new List<int>();
                        condition = cmnd[1];
                        number = int.Parse(cmnd[2]);
                        Filter(integers, number, condition, filteredNumbers);
                        
                        break;
                }
            }

        }

        private static void Filter(List<int> integers, int number, string condition, List<int> filteredNumbers)
        {
            for (int i = 0; i < integers.Count; i++)
            {
                if (condition == "<")
                {
                    if (integers[i] < number)
                    {
                        filteredNumbers.Add(integers[i]);
                    }
                }
                else if (condition == ">")
                {
                    if (integers[i] > number)
                    {
                        filteredNumbers.Add(integers[i]);
                    }
                }
                else if (condition == ">=")
                {
                    if (integers[i] >= number)
                    {
                        filteredNumbers.Add(integers[i]);
                    }
                }
                else if (condition == "<=")
                {
                    if (integers[i] <= number)
                    {
                        filteredNumbers.Add(integers[i]);
                    }
                }
               
            }
            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
        private static void PrintEven(List<int> integers)
        {
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    evenNumbers.Add(integers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", evenNumbers));

        }

        private static void PrintOdd(List<int> integers)
        {
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] % 2 == 1)
                {
                    oddNumbers.Add(integers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", oddNumbers));
        }

        private static int GetSum(List<int> integers)
        {
            int sum = 0;
            for (int i = 0; i < integers.Count; i++)
            {
               
                sum += integers[i];
            }
            return sum;
        }

        
    }
}
