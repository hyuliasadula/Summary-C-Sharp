using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using static _03.Students.Program;

namespace _03.Students
{
    internal class Program
    {
        /*
         Define a class called Student, which will hold the following information about some students:

        · first name
        · last name
        · age
        · home town

        Input / Constraints

        Read information about some students, until you receive the "end" command. After that, you will receive a city name.

        Output

        Print the students who are from the given city in the following format: "{firstName} {lastName} is {age} years old."

        Examples

        Input                                       Output

        John Smith 15 Sofia             John Smith is 15 years old.
        Peter Ivanov 14 Plovdiv         Linda Bridge is 16 years old.
        Linda Bridge 16 Sofia
        Simon Stone 12 Varna
        end
        Sofia 



John Smith 15 Sofia
Peter Ivanov 14 Plovdiv
Linda Bridge 16 Sofia
Simon Stone 12 Varna
end
Sofia


         */

        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Age { get; set; }
            public string HomeTown { get; set; }

        }
        static void Main(string[] args)
        {
           List <Student> students = new List<Student>();

           
            while (true) 
            {
                string[] currentStudent = Console.ReadLine().Split(' ').ToArray();
                if (currentStudent[0].ToLower() == "end")
                {

                    break;
                }
                string firstName = currentStudent[0];
                string lastName = currentStudent[1];
                string age = currentStudent[2];
                string hometown = currentStudent[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = hometown;

                students.Add(student);
            }
            string cityName = Console.ReadLine();
            
                foreach (Student student in students)
                {
                    if (student.HomeTown == cityName)
                    {
                        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                    }
                    
                }
        }
    }
}
