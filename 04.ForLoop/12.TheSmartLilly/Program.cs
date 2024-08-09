using System;

namespace _12.TheSmartLilly
{
    internal class Program
    {
        /*
         Лили вече е на N години. За всеки свой рожден ден тя получава подарък. 
•	За нечетните рождени дни (1, 3, 5...n) получава играчки.
•	За четните рождени дни (2, 4, 6...n) получава пари. 
За втория рожден ден получава 10.00 лв, като сумата се увеличава с 10.00 лв., за всеки следващ четен рожден ден (2 -> 10, 4 -> 20, 6 -> 30...и т.н.). През годините Лили тайно е спестявала парите. Братът на Лили, в годините, които тя получава пари, взима по 1.00 лев от тях. Лили продала играчките получени през годините, всяка за P лева и добавила сумата към спестените пари. С парите искала да си купи пералня за X лева. Напишете програма, която да пресмята, колко пари е събрала и дали ѝ стигат да си купи пералня.
Вход
Програмата прочита 3 числа, въведени от потребителя, на отделни редове:
•	Възрастта на Лили - цяло число в интервала [1...77]
•	Цената на пералнята - число в интервала [1.00...10 000.00]
•	Единична цена на играчка - цяло число в интервала [0...40]
Изход
Да се отпечата на конзолата един ред:
•	Ако парите на Лили са достатъчни:
o	"Yes! {N}" - където N е остатъка пари след покупката
•	Ако парите не са достатъчни:
o	"No! {М}" - където M е сумата, която не достига
Числата N и M трябва да за форматирани до вторият знак след десетичната запетая.

         
         */
        static void Main(string[] args)
        {
            Console.Write("Lilly Age: ");
            int lillyAge =int.Parse(Console.ReadLine());

            Console.Write("Washing Machine Price: ");
            double washingMachinePrice=double.Parse(Console.ReadLine());

            Console.Write("Toy Price: ");
            int toyPrice=int.Parse(Console.ReadLine());

            int toysCount = 0;
            int moneyCount = 0;
            int moneyCountby10 = 0;
            int moneyCountby10Total = 0;
            int brotherMoney = 0;
            int soldToys = 0;

            for (int age = 1; age <= lillyAge; age++)
            {
                if (age % 2 == 0)
                {
                    moneyCount++;
                    // 10lv -1 for the brother
                    moneyCountby10+=10;
                    moneyCountby10Total += moneyCountby10;
                    //the money the brother tooks every even year -> 1lv
                    brotherMoney++;

                }
                else
                {
                    toysCount++;
                    soldToys += toyPrice;
                }
            }

            double totalMoneyCollected = moneyCountby10Total + soldToys - brotherMoney;
            if (totalMoneyCollected > washingMachinePrice)
            {
                Console.WriteLine($"Yes! {Math.Abs(totalMoneyCollected-washingMachinePrice):f2}");
            }
            else
            {
                double absolute = Math.Abs(washingMachinePrice - totalMoneyCollected);
                Console.WriteLine($"No! {absolute:f2}");
            }
        }
    }
}
