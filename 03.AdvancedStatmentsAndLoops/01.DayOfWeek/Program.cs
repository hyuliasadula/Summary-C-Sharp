using System;

namespace _01.DayOfWeek
{
    internal class Program
    {
        /*
         
         Напишете програма, която чете цяло число, въведено от потребителя, и отпечатва ден от седмицата (на английски език), в граници [1...7] или отпечатва "Error" в случай, че въведеното число е невалидно. 

         */
        static void Main(string[] args)
        {
            Console.WriteLine("A number 1-7: ");
            int dayOfTeWeek = int.Parse(Console.ReadLine());

            // switch case version
            switch (dayOfTeWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
            ////if-else vesrion

            if (dayOfTeWeek == 1) Console.WriteLine("Monday");
            else if (dayOfTeWeek == 2) Console.WriteLine("Tuesday");
            else if (dayOfTeWeek == 3) Console.WriteLine("Wednesday");
            else if (dayOfTeWeek == 4) Console.WriteLine("Thursday");
            else if (dayOfTeWeek == 5) Console.WriteLine("Friday");
            else if (dayOfTeWeek == 6) Console.WriteLine("Saturday");
            else if (dayOfTeWeek == 7) Console.WriteLine("Sunday");
            else { Console.WriteLine("Error"); }
        }
    }
}
