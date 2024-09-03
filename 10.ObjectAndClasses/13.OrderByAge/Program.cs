using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.OrderByAge
{
    internal class Program
    {
        /*
         You will receive an unknown number of lines. On each line you will receive an array with 3 elements:
        · The first element is a string - the name of the person
        · The second element a string - the ID of the person
        · The third element is an integer - the age of the person
        If you get a person whose ID you have already received before, update the name and age for that ID with that of the new person. When you receive the command "End", print all of the people, ordered by age.
         


Input 

George 123456 20
Peter 78911 15
Stephen 524244 10
End


        Output

        Stephen with ID: 524244 is 10 years old.
        Peter with ID: 78911 is 15 years old.
        George with ID: 123456 is 20 years old.
         */
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input.Split(' ').ToArray();
                string name = personInfo[0];
                int id = int.Parse(personInfo[1]);
                int age = int.Parse(personInfo[2]);

                Person existingPerson = personList.FirstOrDefault(p => p.ID == id);
                if (existingPerson != null)
                {
                    existingPerson.Name = name;
                    existingPerson.Age = age;
                }
                else
                {
                    Person person = new Person(name, id, age);
                    personList.Add(person);
                }
            }
            List<Person> sortedPeople =personList.OrderBy(s => s.Age).ToList();


            Console.WriteLine();
            foreach (Person person in sortedPeople)
            {
                Console.WriteLine(person);  // Uses the overridden ToString() method
            }
        }
    }
}
