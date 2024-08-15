using System;
using System.Linq;

namespace _11.ArrayRotation
{
    internal class Program
    {

        /*
         Create a program that receives an array and several rotations that you have to perform. The rotations are done by moving the first element of the array from the front to the back. Print the resulting array

        Input           	Output
        51 47 32 61 21
        2	                32 61 21 51 47

         
         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());


            //Reduces to smaller equivalent number if the number of rotations is more than the array length
            rotation = rotation % numbers.Length;

            for (int i = 0; i < rotation; i++)
            {
                int firstElement = numbers[0];

                // rotating the array by 1 

                //Ex:
                //51 47 32 61 21 ->> 47 47 32 61 21 ->> 47 32 32 61 21 ->>
                //47 32 61 61 21 ->> 47 32 61 21 21 ->> 47 32 61 21 51

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
