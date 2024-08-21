using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ChangeList
{
    internal class Program
    {
        /*
         Create a program, that reads a list of integers from the console and receives commands to manipulate the list.

            Your program may receive the following commands:
            Delete {element} – delete all elements in the array, which are equal to the given element.
            Insert {element} {position} – insert the element at the given position.
            You should exit the program when you receive the "end" command. Print all numbers in the array, separated by a single whitespace.

                    Input                               Output

                    1 2 3 4 5 5 5 6                 1 10 2 3 4 6
                    Delete 5 
                    Insert 10 1
                    Delete 5
                    end
         
         */
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> command = input.Split(" ").ToList();
                if (command[0] == "Delete")
                {
                    int elementToRemove = int.Parse(command[1]);
                    // RemoveAll(x => x == elementToRemove)
                    while (list.Contains(elementToRemove))
                    {
                        list.Remove(elementToRemove);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    list.Insert(position, element);
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
