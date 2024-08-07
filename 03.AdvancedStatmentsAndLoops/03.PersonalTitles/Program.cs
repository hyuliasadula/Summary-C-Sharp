using System;

namespace _03.PersonalTitles
{
    internal class Program
    {
        /*
         Да се напише конзолна програма, която прочита възраст (реално число) и пол ('m' или 'f'), въведени от потребителя, и отпечатва обръщение измежду следните:
                •	"Mr." – мъж (пол 'm') на 16 или повече години
                •	"Master" – момче (пол 'm') под 16 години
                •	"Ms." – жена (пол 'f') на 16 или повече години
                •	"Miss" – момиче (пол 'f') под 16 години

         */
        static void Main(string[] args)
        {
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Gender(m/f): ");
            char gender = char.Parse(Console.ReadLine());

            if (age < 16 && gender == 'm')
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16 && gender == 'm')
            {
                Console.WriteLine("Mr.");
            }
            else if (age < 16 && gender == 'f')
            {
                Console.WriteLine("Miss");
            }
            else if (age >= 16 && gender == 'f')
            {
                Console.WriteLine("Mrs.");
            }
        }
    }
}
