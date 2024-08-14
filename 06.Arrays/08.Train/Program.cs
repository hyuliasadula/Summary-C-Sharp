using System;
using System.Linq;

namespace _08.Train
{
    internal class Program
    {
        /* 
        A train has n number of wagons (integer, received as input). On the next n lines, you will receive the number of people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the total number of passengers on the train.


        Input	    Output
            3       13 24 8
            13      45
            24
            8	
         */
        static void Main(string[] args)
        {
            Console.Write("Number of wagons: ");
            int wagons = int.Parse(Console.ReadLine());
            int[] passangers = new int[wagons];
            int sum = 0;



            for (int i = 0; i < wagons; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());
                sum+= passangers[i];
            }

            Console.WriteLine(string.Join(" ", passangers));
            Console.WriteLine(sum);


        }
    }
}
