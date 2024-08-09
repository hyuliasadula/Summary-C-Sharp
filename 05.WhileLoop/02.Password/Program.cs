using System;

namespace _02.Password
{
    internal class Program
    {
        /*
         Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход.
            •	при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
            •	при въвеждане на правилна парола: отпечатваме "Welcome {username}!".

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Username:");
            string username = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            string passwordGuessingAttempts = "";

            Console.WriteLine();
            Console.WriteLine("Password Guesses: ");
            Console.WriteLine();

            while (password != passwordGuessingAttempts)
            {
                passwordGuessingAttempts= Console.ReadLine();
                if (passwordGuessingAttempts == password)
                {
                    Console.WriteLine();
                    Console.WriteLine("Password correct!");
                    Console.WriteLine($"Welcome {username}");
                    break;
                }
            }
        }
    }
}
