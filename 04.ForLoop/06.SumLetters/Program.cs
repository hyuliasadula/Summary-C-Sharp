using System;

namespace _06.SumLetters
{
    internal class Program
    {

        /*
         Да се напише програма, която чете текст (стринг), въведен от потребителя, и изчислява и отпечатва сумата от стойностите на гласните букви според таблицата по-долу:
                буква	    a	e	i	o	u
                стойност	1	2	3	4	5

         */
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {

                    switch (letter)
                    {
                        case 'a':
                            sum += 1;
                            break;
                        case 'e':
                            sum += 2;
                            break;
                        case 'i':
                            sum += 3;
                            break;
                        case 'o':
                            sum += 4;
                            break;
                        case 'u':
                            sum += 5;
                            break;

                    }

                }


            }
            Console.WriteLine(sum);
        }
    }
}
