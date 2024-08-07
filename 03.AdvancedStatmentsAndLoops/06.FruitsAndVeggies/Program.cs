using System;

namespace _06.FruitsAndVeggies
{
    internal class Program
    {
        /*
         Да се напише програма, която чете име на продукт, въведено от потребителя, и проверява дали е плод или зеленчук.
        •	Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
        •	Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot
        •	Всички останали са "unknown"
        Да се изведе "fruit”, "vegetable" или "unknown" според въведения продукт

         */
        static void Main(string[] args)
        {
            
            Console.WriteLine("Product name(banana, apple, kiwi, cherry, lemon, grapes, tomato, cucumber, pepper, carrot ): ");
            string nameOfTheProduct = Console.ReadLine();

            switch (nameOfTheProduct)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    Console.WriteLine($"{nameOfTheProduct} is a fruit!");
                    break;
                case "tomato":
                case "cucumber":
                case "prpper":
                case "carrot":
                    Console.WriteLine($"{nameOfTheProduct} is a vegetable!");
                    break;
                default:
                    Console.WriteLine($"The product '{nameOfTheProduct}' is unknown!");
                    break;
            }
        }
    }
}
