using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Train
{
    internal class Program
    {
        /*
         On the first line, we will receive a list of wagons (integers). Each integer represents the number of passengers that are currently in each wagon of the passenger train. On the next line, you will receive the max capacity of a wagon, represented as a single integer. Until you receive the "end" command, you will be receiving two types of input:

            Add {passengers} – add a wagon to the end of the train with the given number of passengers
            {passengers} – find a single wagon to fit all the incoming passengers (starting from the first wagon).
            In the end, print the final state of the train (all the wagons separated by a space).


                Input                            Output
                                            72 54 21 12 4 75 23 10 0
                32 54 21 12 4 0 23                      
                75
                Add 10
                Add 0
                30
                10
                75
                end 
         
         */
        static void Main(string[] args)
        {
            List<int> passengersPerWagon = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split(" ").ToList();
                if (command[0] == "Add")
                {
                    int strToNumber = int.Parse(command[1]);
                    passengersPerWagon.Add(strToNumber);
                
                }
                else
                {
                    int passengers = int.Parse(command[0]);
                    for (int y = 0; y < passengersPerWagon.Count; y++)
                    {
                        if (passengersPerWagon[y] + passengers <= maxWagonCapacity)
                        {
                            passengersPerWagon[y] += passengers;
                            break; 
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", passengersPerWagon));

        }
    }
}
