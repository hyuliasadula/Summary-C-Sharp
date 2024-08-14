using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        /*
         Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence of space-separated strings. Print the output on a single line (space separated).

                Examples

                Input                                       Output

                a b c d e                                    e d c b a

                -1 hi ho w                                    w ho hi -1
         */
        static void Main(string[] args)
        {
           
            string[] elementsOfString = Console.ReadLine().Split(" ").ToArray();


            for (int i = elementsOfString.Length - 1; i >= 0; i--)
            {
                Console.Write(elementsOfString[i] + " ");
            }
        }
    }
}
