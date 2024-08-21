using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _10.HouseParty
{
    internal class Program
    {
        /*
         Create a program that keeps track of the guests that are going to a house party. On the first line, of input you are going to receive the number of commands that will follow.

        On the next lines, you are going to receive some of the following: "{name} is going!"
        · You have to add the person, if they are not on the guestlist already
        · If the person is on the list print the following to the console: "{name} is already in the list!"
        "{name} is not going!"
        · You have to remove the person, if they are on the list.
        · If not, print out: "{name} is not in the list!"
        Finally, print all of the guests, each on a new line.

             Input                           Output
    
            4
            Allie is going!                 John is not in the list!
            George is going!                Allie
            John is not going!
            George is not going! 
         */
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 1; i <= numberOfCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split(" ").ToList();
                if (commands[2] == "not")
                {
                    if (names.Contains(commands[0]))
                    {
                        names.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
                else
                {
                    if (names.Contains(commands[0]))
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(commands[0]);
                    }
                }
            }
            foreach (string name in names)
            {
               
                    Console.WriteLine(name);
            }
        }
    }
}
