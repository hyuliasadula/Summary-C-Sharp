using System;

namespace _03.ReadFromConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type Name
            Console.WriteLine("name");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            //Type Number
            Console.WriteLine("int number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);

            //Type Double Number
            Console.WriteLine("double number");
            double doubleNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(doubleNumber);

            //Type Char
            Console.WriteLine("char");
            char character = char.Parse(Console.ReadLine());
            Console.WriteLine(character);
        }
    }
}
