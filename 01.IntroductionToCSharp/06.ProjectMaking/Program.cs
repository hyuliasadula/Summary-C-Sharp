using System;

namespace _06.ProjectMaking
{
    internal class Program
    {
        /*
         Напишете програма, която изчислява колко часа ще са необходими на един архитект, за да изготви проектите на няколко строителни обекта. Изготвянето на един проект отнема три часа.


        input           output
        George
            4	  ->  The architect George will need 12 hours to complete 4 project/s.

         */
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("How many projects: ");
            int projects = int.Parse(Console.ReadLine());

            //3 hours to complete a project
            int aCompletedProject = 3;
            int neededTime = projects * aCompletedProject;
            Console.WriteLine($"The architect {name} will need {neededTime} hours to complete {projects} project/s.");
        }
    }
}
