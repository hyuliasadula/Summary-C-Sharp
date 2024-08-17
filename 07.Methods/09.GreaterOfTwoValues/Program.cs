using System;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        /*
         You are given an input of two values of the same type. The values can be of type int, char or string. Create methods called GetMax(), which can compare int, char or string and returns the biggest of the two values.

            Examples
            Input       Output

            int
            2
            16          16

            char
            a
            z           z

            string
            aaa
            bbb         bbb
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Type (int, char, string)");
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int fisrtNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    int intResult = GetMax(fisrtNum, secondNum);
                    Console.WriteLine(intResult);
                    break;
                case "char":
                    char fisrtChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char charResult = GetMax(fisrtChar, secondChar);
                    Console.WriteLine(charResult);
                    break;
                case "string":
                    string firtsStr = Console.ReadLine();
                    string secondStr = Console.ReadLine();
                    string strResult =GetMax(firtsStr, secondStr);
                    Console.WriteLine(strResult);
                    break;
            }
        }

        private static string GetMax(string firtsStr, string secondStr)
        {
            int result = string.Compare(firtsStr, secondStr);

            if (result < 0)
            {
                return secondStr;
                
            }
            else 
            {
                return firtsStr;
                
            }
        }

        private static char GetMax(char fisrtChar, char secondChar)
        {
            if (fisrtChar > secondChar)
            {
                return fisrtChar;
            }
            else
            {
                return secondChar;
            }
            
        }

        private static int GetMax(int fisrtNum, int secondNum)
        {
            if (fisrtNum > secondNum)
            {
                return fisrtNum;
            }
            else
            {
                return secondNum;
            }
            
        }
    }
}
