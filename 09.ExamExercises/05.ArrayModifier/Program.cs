using System;
using System.Linq;

namespace _05.ArrayModifier
{
    internal class Program
    {

        /*
         You are given an array with integers. Write a program to modify the elements after receiving the following commands:
        •	"swap {index1} {index2}" takes two elements and swap their places.
        •	"multiply {index1} {index2}" takes element at the 1st index and multiply it with the element at 2nd index. Save the product at the 1st index.
        •	"decrease" decreases all elements in the array with 1.
        Input
        On the first input line, you will be given the initial array values separated by a single space.
        On the next lines, you will receive commands until you receive the command "end". The commands are as follows: 
        •	"swap {index1} {index2}"
        •	"multiply {index1} {index2}"
        •	"decrease"
        Output
        The output should be printed on the console and consist of elements of the modified array – separated by a comma and a single space ", ".
        Constraints
        •	Elements of the array will be integer numbers in the range [-231...231].
        •	Count of the array elements will be in the range [2...100].
        •	Indexes will be always in the range of the array.

         

        Input                                               Output
        23 -2 321 87 42 90 -123                          86, 7382, 2369942, -124, 41, 89, -3
        swap 1 3
        swap 3 6
        swap 1 0
        multiply 1 2
        multiply 2 1
        decrease
        end	       
        

        Comment 

        23 -2 321 87 42 90 -123 – initial values
        swap 1(-2) and 3(87) ▼
        23 87 321 -2 42 90 -123
        swap 3(-2) and 6(-123) ▼
        23 87 321 -123 42 90 -2
        swap 1(87) and 0(23) ▼
        87 23 321 -123 42 90 -2
        multiply 1(23) 2(321) = 7383 ▼
        87 7383 321 -123 42 290 -2
        multiply 2(321) 1(7383) = 2369943 ▼
        87 7383 2369943 -123 42 90 -2
        decrease – all - 1 ▼
        86 7383 2369942 -124 41 89 -3

         */
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] copy= new int[numbers.Length];

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end") 
            {
                if (command[0] == "swap")
                {

                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);

                    int temp = numbers[index1];
                    numbers[index1] = numbers[index2];
                    numbers[index2] = temp;

                }
                else if (command[0] == "multiply")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    numbers[index1] *= numbers[index2];
                }
                else if (command[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
