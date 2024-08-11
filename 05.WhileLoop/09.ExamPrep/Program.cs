using System;

namespace _09.ExamPrep
{
    internal class Program
    {
        /*
            Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение "Enough" от лектора си. При всяка решена задача той получава оценка. Програмата трябва да приключи прочитането на данни при команда "Enough" или ако Марин получи определения брой незадоволителни оценки.
              Незадоволителна е всяка оценка, която е по-малка или равна на 4.

            Вход
                •	На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
                •	След това многократно се четат по два реда:
                o	Име на задача - текст (низ)
                o	Оценка - цяло число в интервала [2…6]
            Изход
                •	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда: 
                o	"Average score: {средна оценка}"
                o	"Number of problems: {броя на всички задачи}"
                o	"Last problem: {името на последната задача}"
                •	Ако получи определеният брой незадоволителни оценки:
                o	"You need a break, {брой незадоволителни оценки} poor grades."
                Средната оценка да бъде форматирана до втория знак след десетичната запетая. 
         */
        static void Main(string[] args)
        {
            Console.Write("Bad Grades: ");
            int badGrades = int.Parse(Console.ReadLine());

            string taskName = "";
            int grade = 0;
            int badGradesCounter = 0;

            double avarageGradeSum = 0;
            int gradesCounter = 0;

            int tasksCounter = 0;
            string lastTask = "";

            while (taskName != "Enough")
            {
                Console.Write("Task name: ");
                taskName = Console.ReadLine();


                if (taskName != "Enough")
                {
                    lastTask = taskName;
                }

                tasksCounter++;

                if (taskName == "Enough")
                {
                    avarageGradeSum = avarageGradeSum / gradesCounter;
                    Console.WriteLine($"Average score: {avarageGradeSum}");

                    //tasks counter - 1 -> substracting the "Enough" from tasks name 
                    Console.WriteLine($"Number of problems: {tasksCounter-1}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;

                }
                Console.Write("Grade: ");
                grade = int.Parse(Console.ReadLine());
                
                gradesCounter++;
                avarageGradeSum+= grade;

                if (grade <= 4)
                {
                    badGradesCounter++;
                    if (badGradesCounter == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGradesCounter} poor grades.");
                        break;
                    }
                }
                
            }
        }
    }
}
