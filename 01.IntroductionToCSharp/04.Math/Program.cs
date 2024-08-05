using System;

namespace _04.Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
//+  -> you can replace with any other operations - * / and types
            Console.WriteLine("+");
            Console.WriteLine("Type an int number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Type an int number");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The result is: ");
            Console.WriteLine(sum);

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

// % остатък
// 7 / 2 = 3  -> остатък 1 
            Console.WriteLine("Remainder");
            int a = 7;
            int b = 2;
            int product = a % b;
            Console.WriteLine(product);

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

//odd even
            Console.WriteLine("Odd Even");
            Console.WriteLine("Odd : 3 % 2");
            int odd = 3 % 2;
            Console.WriteLine(odd);

            Console.WriteLine("Even : 4 % 2");
            int even = 4 % 2;
            Console.WriteLine(even);


                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

//Combine Text and Number in one line
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {firstName} {lastName}, Age: {age}");

        }
    }
}
