using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        /*
         Create a program that reads a list of integers. Then until you receive "end", you will receive different commands:

            Add {number}: add a number to the end of the list.
            Remove {number}: remove a number from the list.
            RemoveAt {index}: remove a number at a given index.
            Insert {number} {index}: insert a number at a given index.
            Note: All the indices will be valid!
            When you receive the "end" command, print the final state of the list (separated by spaces).

                Input               Output

           4 19 2 53 6 43           4 53 6 8 43 3
           Add 3
           Remove 2
           RemoveAt 1
           Insert 8 3
           end 
         */
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (true)
            {
                List<string> cmnd = Console.ReadLine().Split(" ").ToList();

                if (cmnd[0] == "end")
                {
                    break;
                }

                string command = cmnd[0];
                int number, index;

                switch (command)
                {
                    case "Add":
                        number = int.Parse(cmnd[1]);
                        integers.Add(number);
                        break;

                    case "Remove":
                        number = int.Parse(cmnd[1]);
                        integers.Remove(number);
                        break;

                    case "RemoveAt":
                        index = int.Parse(cmnd[1]);
                        integers.RemoveAt(index);
                        break;

                    case "Insert":
                        number = int.Parse(cmnd[1]);
                        index = int.Parse(cmnd[2]);
                        integers.Insert(index, number);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
