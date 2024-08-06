using System;

namespace _08.SumTheSeconds
{
    internal class Program
    {
        /*Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50). Да се напише програма, която чете времената на състезателите в секунди, въведени от потребителя и пресмята сумарното им време във формат "минути:секунди". Секундите да се изведат с водеща нула (2 > "02", 7 > "07", 35 > "35"). */
        static void Main(string[] args)
        {
            Console.Write("First pesron: ");
            int firstPerson = int.Parse(Console.ReadLine());

            Console.Write("Second pesron: ");
            int secondPerson = int.Parse(Console.ReadLine());

            Console.Write("Third pesron: ");
            int thirsPerson = int.Parse(Console.ReadLine());

            int total = firstPerson + secondPerson + thirsPerson;
            int totalMinutes = total / 60;
            int totalSeconds = total % 60;

            if (totalSeconds < 10)
            {
                Console.WriteLine($"{totalMinutes}:0{totalSeconds}");
            }
            else
            {
                Console.WriteLine($"{totalMinutes}:{totalSeconds}");
            }
        }
    }
}
