using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    internal class Program
    {
        /*
         You are going to receive two lists of numbers. Create a list that contains the numbers from both of the lists. The first element should be from the first list, the second from the second list, and so on. If the length of the two lists is not equal, just add the remaining elements at the end of the list

        Input                               Output

        3 5 2 43 12 3 54 10 23

        76 5 34 2 4 12                      3 76 5 5 2 34 43 2 12 4 3 12 54 10 23
         
         */
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> result = new List<int>();

            MergingNumbers(firstList, secondList, result);
            
            
        }

        private static void MergingNumbers(List<int> firstList, List<int> secondList, List<int> result)
        {
            int minLength = Math.Min(firstList.Count, secondList.Count);


            for (int i = 0; i < minLength; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            if (firstList.Count > minLength)
            {
                for (int i = minLength; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else if (secondList.Count > minLength)
            {
                for (int i = minLength; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
    
}
