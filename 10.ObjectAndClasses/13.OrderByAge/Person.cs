using System;
using System.Collections.Generic;
using System.Text;

namespace _13.OrderByAge
{
    internal class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public Person(string name, int id, int age) 
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public override string ToString() 
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
