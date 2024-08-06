using System;

namespace _09.BonusPoints
{
    internal class Program
    {
        /*Дадено е цяло число – начален брой точки. Върху него се начисляват бонус точки по правилата, описани по-долу. Да се напише програма, която пресмята бонус точките, които получава числото и общия брой точки (числото + бонуса).
•	Ако числото е до 100 включително, бонус точките са 5.
•	Ако числото е по-голямо от 100, бонус точките са 20% от числото.
•	Ако числото е по-голямо от 1000, бонус точките са 10% от числото.

•	Допълнителни бонус точки (начисляват се отделно от предходните):
o	За четно число  + 1 т.
o	За число, което завършва на 5  + 2 т.
*/
        static void Main(string[] args)
        {
            Console.Write("Type the start points: ");
            double startPoints = double.Parse(Console.ReadLine());
            double startPointSave = startPoints;
            double bonus = 0.0;

            double bonusPointsCount = 0.0;

            if (startPoints % 2 == 0)
            {
                bonusPointsCount++;
            }
            else if (startPoints % 10 == 5)
            {
                bonusPointsCount+=2;
            }

            if (startPoints <=100)
            {
                bonusPointsCount += 5;
            }
            else if (startPoints > 100 && startPoints <=1000)
            {
                bonus = 0.2;
                bonusPointsCount+= startPoints*bonus;
            }
            else
            {
                bonus = 0.1;
                bonusPointsCount += startPoints * bonus;
            }
            Console.WriteLine(bonusPointsCount);
            Console.WriteLine(startPointSave+bonusPointsCount);
        }
    }
}
