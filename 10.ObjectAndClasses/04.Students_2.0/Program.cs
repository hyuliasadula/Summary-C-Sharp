using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students_2._0
{
    internal class Program
    {
        /*
         Use the class from the previous problem. If you receive a student, which already exists (first name and last name should be unique) overwrite the information.
        Input

John Smith 15 Sofia
Peter Johnson 14 Plovdiv
Peter Johnson 25 Plovdiv
Linda Bridge 16 Sofia
Linda Bridge 27 Sofia
Simon Stone 12 Varna
end
Sofia

        Output
John Smith is 15 years old.
Linda Bridge is 27 years old.
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
            List<Student> students = new List<Student>();


            while (true)
            {
                string[] currentStudent = Console.ReadLine().Split(' ').ToArray();
                if (currentStudent[0].ToLower() == "end")
                {

                    break;
                }
                string[] studentData = currentStudent;
                string firstName = studentData[0];
                string lastName = studentData[1];
                string age = studentData[2];
                string hometown = studentData[3];


                Student existingStudent = null;
                foreach (Student student in students)
                {
                    if (student.FirstName == firstName && student.LastName == lastName)
                    {
                        existingStudent = student;
                        break; 
                    }
                }

                if (existingStudent != null)
                {
                    
                    existingStudent.Age = age;
                    existingStudent.HomeTown = hometown;
                }
                else
                {
                    Student newStudent = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = hometown
                    };
                    students.Add(newStudent);
                }
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
