using System;

namespace _01.ReadText
{
    internal class Program
    {
        //Напишете програма, която чете текст от конзолата (стринг) и го принтира, докато не получи командата "Stop".
        static void Main(string[] args)
        {
            Console.WriteLine("Write something: ");
            string text = "";

            while (text != "Stop")
            {
                
                text = Console.ReadLine();
                if (text == "Stop")
                {
                    break;
                }
                Console.WriteLine(text);
                
            }
        }
    }
}
