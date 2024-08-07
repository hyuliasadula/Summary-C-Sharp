using System;

namespace _09.NewHome
{
    internal class Program
    {
        /*
         Марин и Нели си купуват къща не далеч от София. Нели толкова много обича цветята, че Ви убеждава да напишете програма която да изчисли колко  ще им струва, да си засадят определен брой цветя и дали наличния бюджет ще им е достатъчен. Различните цветя са с различни цени. 
                       цвете	Роза	Далия	Лале	Нарцис	Гладиола
            Цена на брой в лева	   5	3.80	2.80	  3	     2.50
            Съществуват следните отстъпки:
            •	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
            •	Ако Нели купи повече от 90  Далии - 15% отстъпка от крайната цена
            •	Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
            •	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
            •	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%
            От конзолата се четат 3 реда:
            •	Вид цветя - текст с възможности - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            •	Брой цветя - цяло число в интервала [10…1000]
            •	Бюджет - цяло число в интервала [50…2500]
            Да се отпечата на конзолата на един ред
            •	Ако бюджета им е достатъчен - "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            •	Ако бюджета им е НЕ достатъчен - "Not enough money, you need {нужната сума} leva more."
            Сумата да бъде форматирана до втория знак след десетичната запетая.

         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Flower name(\"Roses\", \"Dahlias\", \"Tulips\", \"Narcissus\", \"Gladiolus\")");
            string flowerName = Console.ReadLine();

            Console.WriteLine("Flower quantity: ");
            int flowerQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Budget: ");
            int budget = int.Parse(Console.ReadLine());
            double discountOrMarkup = 0;
            double totalPrice = 0;

            switch (flowerName)
            {
                /*
                   •	Ако Нели купи повече от 80 Рози - 10% отстъпка от крайната цена
            •	Ако Нели купи повече от 90  Далии - 15% отстъпка от крайната цена
            •	Ако Нели купи повече от 80 Лалета - 15% отстъпка от крайната цена
            •	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15%
            •	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20%
                
                 */
                case "Roses":
                    
                    if (flowerQuantity > 80)
                    {
                        totalPrice = 5 * flowerQuantity;
                        discountOrMarkup = 0.1;
                        totalPrice = totalPrice - (totalPrice * discountOrMarkup);
                    }
                    else
                    {
                        totalPrice = 5 * flowerQuantity;
                    }
                    
                    break;
                case "Dahlias":
                    
                    if (flowerQuantity > 90)
                    {
                        totalPrice = 3.8 * flowerQuantity;
                        discountOrMarkup = 0.15;
                        totalPrice = totalPrice - (totalPrice * discountOrMarkup);
                    }
                    else
                    {
                        totalPrice = 3.8 * flowerQuantity;
                    }
                    break;
                case "Tulips":
                    
                    if (flowerQuantity > 80)
                    {
                        totalPrice = 2.8 * flowerQuantity;
                        discountOrMarkup = 0.15;
                        totalPrice = totalPrice-(totalPrice*discountOrMarkup);
                    }
                    else
                    {
                        totalPrice = 2.8 * flowerQuantity;
                    }
                    break;
                case "Narcissus":
                    
                    if (flowerQuantity < 120)
                    {
                        totalPrice = 3 * flowerQuantity;
                        discountOrMarkup = 1.15;
                        totalPrice *= discountOrMarkup;
                    }
                    else
                    {
                        totalPrice = 3 * flowerQuantity;
                    }
                    break;
                case "Gladiolus":
                    
                    if (flowerQuantity < 80)
                    {
                        totalPrice = 2.5 * flowerQuantity;
                        discountOrMarkup = 1.2;
                        totalPrice *= discountOrMarkup;
                    }
                    else
                    {
                        totalPrice = 2.5 * flowerQuantity;
                    }
                    break;
            }
            if (budget>totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerName} and {(budget-totalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice-budget):f2} leva more.");
            }
        }
    }
}
