using System;

namespace _04.CharacterSequence
{
    internal class Program
    {
        /*
         Напишете програма, която чете текст (стринг), въведен от потребителя и печата всеки символ от текста на отделен ред.
         */
        static void Main(string[] args)
        {
            Console.Write("Write any text here: ");
            string text = Console.ReadLine();
            
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                Console.WriteLine(letter);
            }
            
        }
    }
}
