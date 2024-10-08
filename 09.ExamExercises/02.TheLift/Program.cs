﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TheLift
{
    internal class Program
    {
        /*
         Write a program that finds a place for the tourist on a lift.

Every wagon should have a maximum of 4 people on it. If a wagon is full, you should direct the people to the next one with space available.

Input

· On the first line, you will receive how many people are waiting to get on the lift.

· On the second line, you will receive the current state of the lift separated by a single space ' '.

Output

When there is no more available space left on the lift, or there are no more people in the queue, you should print on the console the final state of the lift's wagons separated by ' ' and one of the following messages:

· If there are no more people and the lift has empty spots, you should print:

"The lift has empty spots!

{wagons separated by ' '}"

· If there are still people in the queue and no more available space, you should print:

"There isn't enough space! {people} people in a queue!

{wagons separated by ' '}"

· If the lift is full and there are no more people in the queue, you should print only the wagons separated by " "
         
         
         */
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> currentStateOfLift = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int maximumPeople = 4;

                                //ex 4
            for (int i = 0; i < currentStateOfLift.Count; i++) 
            { 
                // 0 0 0 0
                if (currentStateOfLift[i] < 4 && peopleWaiting > 0)
                {
                    while (currentStateOfLift[i] != 4 && peopleWaiting > 0)
                    {
                        currentStateOfLift[i] += 1;
                        peopleWaiting--;
                    }
                    continue;
                }
            }
            if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                Console.WriteLine(string.Join(" ", currentStateOfLift));
            }
        }
    }
}
