using System;

namespace _10.Vacation
{
    internal class Program
    {
        /*
         Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере необходимата сума. Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.
            Вход
            От конзолата се четат:
            •	Пари нужни за екскурзията - реално число в интервала [1.00...25000.00]
            •	Налични пари - реално число в интервала [0.00...25000.00]
            След това многократно се четат по два реда:
            •	Вид действие – текст с възможности "spend" и "save"
            •	Сумата, която ще спести / похарчи - реално число в интервала [0.01… 25000.00]
            Изход
            Програмата трябва да приключи при следните случаи:
            •	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
            o	"You can't save the money."
            o	"{Общ брой изминали дни}"
            •	Ако Джеси събере парите за почивката на конзолата се изписва:
            o	"You saved the money for {общ брой изминали дни} days."
         */
        static void Main(string[] args)
        {
            Console.Write("Needed money for the vacation: ");
            double neededMoney = double.Parse(Console.ReadLine());
            

            Console.Write("Money collected: ");
            double collectedMoney = double.Parse(Console.ReadLine());

            string action = "";
            double moneySpendOrSaved = 0;

            int daysCount = 0;
            int spendCount = 0;

            double currentMoney = 0;
            while (true)
            {
                if (daysCount == 0)
                {
                    currentMoney = neededMoney;
                }
                
                action = Console.ReadLine();
                moneySpendOrSaved = double.Parse(Console.ReadLine());
                daysCount++;
                if (action == "spend")
                {
                    currentMoney -= moneySpendOrSaved;
                    spendCount++;
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                }
                else
                {
                    currentMoney += moneySpendOrSaved;
                    spendCount = 0;
                }
                if (currentMoney > neededMoney)
                {
                    Console.WriteLine($"You saved the money for {daysCount} days");
                    break;
                }
                
            }
        }
    }
}
