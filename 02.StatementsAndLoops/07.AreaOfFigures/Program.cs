using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        /*
         Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й. Фигурите са четири вида: квадрат (square), правоъгълник (rectangle), кръг (circle) и триъгълник (triangle). На първия ред на входа се чете вида на фигурата (текст със следните възможности: square, rectangle, circle или triangle). 
            •	Ако фигурата е квадрат (square): на следващия ред се чете едно дробно число - дължина на страната му
            •	Ако фигурата е правоъгълник (rectangle): на следващите два реда четат две дробни числа - дължините на страните му
            •	Ако фигурата е кръг (circle): на следващия ред чете едно дробно число - радиусът на кръга
            •	Ако фигурата е триъгълник (triangle): на следващите два реда четат две дробни числа - дължината на страната му и дължината на височината към нея
            Резултатът да се закръгли до 3 цифри след десетичната запетая. 

         */
        static void Main(string[] args)
        {
            Console.Write("Figure: ");
            string figureType = Console.ReadLine();

            double sum = 0;

            switch (figureType)
            {
                case "square":
                    Console.Write("The length of the square: ");
                    double squareLength = double.Parse(Console.ReadLine());
                    sum = squareLength * squareLength;
                    Console.WriteLine($"{sum:f3}");
                    break;
                case "rectangle":
                    Console.Write("First number: ");
                    double firstNumber = double.Parse(Console.ReadLine());
                    Console.Write("Second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());
                    sum = firstNumber * secondNumber;
                    Console.WriteLine($"{sum:f3}");
                    break;
                case "circle":
                    Console.Write("The radius of the square: ");
                    double radius = double.Parse(Console.ReadLine());
                    double pi = 3.14159265359;
                    sum = (radius * radius)*pi;
                    Console.WriteLine($"{sum:f3}");
                    break;
                case "triangle":
                    Console.Write("Length: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    sum = (length * height)/2;
                    Console.WriteLine($"{sum:f3}");
                    break;
            }
        }
    }
}
