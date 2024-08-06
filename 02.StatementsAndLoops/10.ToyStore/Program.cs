using System;

namespace _10.ToyStore
{
    internal class Program
    {
        /*
         Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да изпълни. С парите, които ще спечели иска да отиде на екскурзия. 
Цени на играчките:
•	Пъзел - 2.60 лв.
•	Говореща кукла - 3 лв.
•	Плюшено мече - 4.10 лв.
•	Миньон - 8.20 лв.
•	Камионче - 2 лв.
Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25% от общата цена. От спечелените пари Петя трябва да даде 10% за наема на магазина. Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
Вход
От конзолата се четат 6 реда:
1.	Цена на екскурзията - реално число в интервала [1.00 … 10000.00]
2.	Брой пъзели - цяло число в интервала [0… 1000]
3.	Брой говорещи кукли - цяло число в интервала [0 … 1000]
4.	Брой плюшени мечета - цяло число в интервала [0 … 1000]
5.	Брой миньони - цяло число в интервала [0 … 1000]
6.	Брой камиончета - цяло число в интервала [0 … 1000]
Изход
На конзолата се отпечатва:
•	Ако парите са достатъчни се отпечатва:
o	"Yes! {оставащите пари} lv left."
•	Ако парите НЕ са достатъчни се отпечатва:
o	"Not enough money! {недостигащите пари} lv needed."

Резултатът трябва да се форматира до втория знак след десетичната запетая.

         */
        static void Main(string[] args)
        {
            //Toys prices
            double puzzlePrice = 2.6;
            double talkingDollPrice = 3.0;
            double teddyBearPrice = 4.10;
            double minionPrice = 8.2;
            double truckPrice = 2.0;

            //input
            Console.Write("Vacation price: ");
            double vacationPrice = double.Parse(Console.ReadLine());

            Console.Write("Puzzles count: ");
            int puzzleCount = int.Parse(Console.ReadLine());
            Console.Write("Talking dolls count: ");
            int talkingDollCount = int.Parse(Console.ReadLine());
            Console.Write("Teddy Bears count: ");
            int teddyBearCount = int.Parse(Console.ReadLine());
            Console.Write("Minions count: ");
            int minionCount = int.Parse(Console.ReadLine());
            Console.Write("Trucks count: ");
            int truckCount = int.Parse(Console.ReadLine());
            double discountPrice = 0;
            double totalPriceBeforeDiscount = (puzzlePrice * puzzleCount)+(talkingDollCount*talkingDollPrice)+(teddyBearCount*teddyBearPrice)+(minionCount*minionPrice)+(truckCount*truckPrice);


            int totalProductCount = puzzleCount + talkingDollCount + teddyBearCount+ minionCount + truckCount;
            if (totalProductCount >= 50)
            {
                double discount = 0.25;
                discountPrice = totalPriceBeforeDiscount * discount;

            }

            double totalPrice = totalPriceBeforeDiscount - discountPrice;

            double rentPricePercentage = 0.1;
            double rentPrice =totalPrice * rentPricePercentage;

            totalPrice = totalPrice - rentPrice;


            if (vacationPrice < totalPrice)
            {
                Console.WriteLine($"Yes! {totalPrice-vacationPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacationPrice-totalPrice:f2} lv needed.");
            }
        }
    }
}
