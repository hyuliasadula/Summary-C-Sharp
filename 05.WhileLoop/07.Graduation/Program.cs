using System;

namespace _07.Graduation
{
    internal class Program
    {
        /*
         Напишете програма, която изчислява средната оценка на ученик от цялото му обучение. На първия ред ще получите името на ученика, а на всеки следващ ред неговите годишни оценки. Ученикът преминава в следващия клас, ако годишната му оценка е по-голяма или равна на 4.00. Ако ученикът бъде скъсан повече от един път, то той бива изключен и програмата приключва, като се отпечатва името на ученика и в кой клас бива изключен.
                 При успешно завършване на 12-ти клас да се отпечата : 
                "{име на ученика} graduated. Average grade: {средната оценка от цялото обучение}"
                В случай, че ученикът е изключен от училище, да се отпечата:
                "{име на ученика} has been excluded at {класа, в който е бил изключен} grade"
                Стойността трябва да бъде форматирана до втория знак след десетичната запетая.  

         
         */
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();    
            double yearlyGrades = double.Parse(Console.ReadLine());
            int yearCount = 1;
            int failedYears = 0;
            double gradesSum = 0;

            while (yearCount < 12)
            {

                if (yearlyGrades < 4)
                {
                    failedYears++;
                    if (failedYears >= 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {yearCount-1} grade.");
                    }
                }
                gradesSum += yearlyGrades;
                yearlyGrades = double.Parse(Console.ReadLine());
                yearCount++;
            }
            gradesSum += yearlyGrades;
            Console.WriteLine($"{studentName} graduated. Average grade: {((double)gradesSum/yearCount):f2}");
        }
    }
}
