using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace _10.Students
{
    internal class Program
    {
        /*
         Create a program that sorts some students by their grade in descending order. Each student should have:
· First name (string)
· Last name (string)
· Grade (a floating-point number)
Input
· On the first line, you will receive a number n - the count of all students.
. On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}".
        Output
Print out the information about each student in the following format: "{first name} {second name}: {grade}".
Example
Input
4
Lakia Eason 3.90
Prince Messing 5.49
Akiko Segers 4.85
Rocco Erben 6.00 
        
     Output
        Rocco Erben: 6.00
        Prince Messing: 5.49
        Akiko Segers: 4.85
        Lakia Eason: 3.90
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Count of all students: ");
            int countOfAllStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfAllStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split(' ').ToArray();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                double grade = double.Parse(studentInfo[2]);  // Parse grade as double

                // New Student object 
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            // Sorting by descending order
            List<Student> sortedStudents = students.OrderByDescending(s => s.Grade).ToList();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Students List:");
            Console.WriteLine();

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine(student);  // Uses the overridden ToString() method
            }
        }
    }
}
