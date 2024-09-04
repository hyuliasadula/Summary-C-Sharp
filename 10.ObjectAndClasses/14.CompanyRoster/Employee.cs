using System;
using System.Collections.Generic;
using System.Text;

namespace _14.CompanyRoster
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, double salary, string departmet) 
        { 
            Name = name;
            Salary = salary;
            Department = departmet;
        }

        public override string ToString()
        {
            return $""; 
        }
    }
}
