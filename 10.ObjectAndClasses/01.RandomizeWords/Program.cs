using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RandomizeWords
{
    /*
     You will be given a string that will contain words separated by a single space. Randomize their order and print each word on a new line.

        Examples
        Input

        Welcome to SoftUni and have fun learning programming

        Output 
        learning
        Welcome
        SoftUni
        and
        fun
        programming
        have
        to 
    
    Comments
    The order of the words in the output will be different after each program execution.

        Hints
        Split the input string by (space) and create an array of words.
        Create a random number generator – an object rnd of type Random.
        In a for loop exchange each number at positions 0, 1,…,words.Length-1 by a number at random position. To generate a random number in range use rnd.Next(minValue, maxValue). Note that by definition minValue is inclusive, but maxValue is exclusive.

        Print each word in the array on new line.
     */
    internal class Program
    {
        //Using the Built-in .NET Classes
        static void Main(string[] args)
        {
            List<string> sentence = Console.ReadLine().Split(' ').ToList();

            Random rnd = new Random();

            for (int i = 0; i < sentence.Count; i++)
            {
                int randomIndex = rnd.Next(i, sentence.Count);

                string temp = sentence[i];
                sentence[i] = sentence[randomIndex];
                sentence[randomIndex] = temp;
            }
            foreach (var word in sentence)
            {
                Console.WriteLine(word);
            }
        }
    }
}
