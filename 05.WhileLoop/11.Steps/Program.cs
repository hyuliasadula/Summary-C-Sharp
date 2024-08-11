using System;

namespace _11.Steps
{
    internal class Program
    {
        /*
         Габи иска да започне здравословен начин на живот и си е поставила за цел да върви 10 000 стъпки всеки ден. Някои дни обаче е много уморена от работа и ще иска да се прибере преди да постигне целта си. Напишете програма, която чете от конзолата по колко стъпки изминава тя всеки път като излиза през деня и когато постигне целта си да се изписва "Goal reached! Good job!"  и колко стъпки повече е извървяла "{разликата между стъпките} steps over the goal!"
        Ако иска да се прибере преди това, тя ще въведе командата "Going home" и ще въведе стъпките, които е извървяла докато се прибира. След което, ако не е успяла да постигне целта си, на конзолата трябва да се изпише: "{разликата между стъпките} more steps to reach goal."

         */
        static void Main(string[] args)
        {
            string steps = "";
            int stepsCounter = 0;
            int stepGoals = 10000;
            bool isGoingHome = false;
            
            while (true) 
            {
                steps = Console.ReadLine();
                
                if (steps == "Going home")
                {
                    
                    isGoingHome= true;
                    break;
                }
                int currentSteps = int.Parse(steps);
                stepsCounter += currentSteps;
                if (stepsCounter >= stepGoals)
                {
                    int stepsOverTarget = stepsCounter - stepGoals;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsOverTarget} steps over the goal!");
                }
            }
            if (isGoingHome)
            {
                int stepsTillHome = int.Parse(Console.ReadLine());
                int stepsUnderTarget = Math.Abs(stepGoals - stepsCounter - stepsTillHome);
                Console.WriteLine($"{stepsUnderTarget} more steps to reach goal.");
            }
        }
    }
}
