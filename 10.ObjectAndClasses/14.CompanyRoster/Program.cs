using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.CompanyRoster
{
    internal class Program
    {
        /*
         Define a class Employee that holds the following information: a name, a salary and a department.
Your task is to write a program, which takes N lines of employees from the console, calculates the department with the highest average salary, and prints for each employee in that department their name and salary – sorted by salary in descending order. The salary should be rounded to two digits after the decimal separator.

Input 
4
Peter 120.00 Development
Tony 333.33 Marketing
Jony 840.20 Development
George 0.20 Nowhere

        Output
        Highest Average Salary: Development
        Jony 840.20 
        Peter 120.00
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Number of employees: ");
            int employeesCount = int.Parse(Console.ReadLine());
            List<Employee> employeesList = new List<Employee>();

            for (int i = 0; i < employeesCount; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split(" ").ToArray();
                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string departmet = employeeInfo[2];
                Employee employee = new Employee(name, salary, departmet);
                employeesList.Add(employee);

                
            }

            var departmentWithHighestAvgSalary = employeesList
            // Group the employees by their department
            .GroupBy(e => e.Department)
            // Project each group into a new anonymous object with three properties:
            // Department, AverageSalary, and Employees (sorted by salary in descending order)
            .Select(g => new
            {
                // The department name (key of the group)
                Department = g.Key,
                // Calculate the average salary for the group
                AverageSalary = g.Average(e => e.Salary),
                // Sort the employees in the group by salary in descending order and convert to a list
                Employees = g.OrderByDescending(e => e.Salary).ToList()
            })
            // Sort the anonymous objects by average salary in descending order
            .OrderByDescending(d => d.AverageSalary)
            // Get the first object (department with the highest average salary)
            .First();

            // Print the name of the department with the highest average salary
            Console.WriteLine($"Highest Average Salary: {departmentWithHighestAvgSalary.Department}");

            // Iterate over each employee in the highest average salary department
            foreach (var employee in departmentWithHighestAvgSalary.Employees)
            {
                // Print the employee's name and salary formatted to two decimal places
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }

        }
    }
}
/*
 Explanation code from ChatGpt (still learning)
1. var departmentWithHighestAvgSalary = employeesList
Explanation: This declares a variable named departmentWithHighestAvgSalary that will store the department with the highest average salary. The type of this variable is inferred by the compiler based on the result of the LINQ query that follows.
employeesList is a list containing all the Employee objects.
2. .GroupBy(e => e.Department)
Explanation: This groups the employeesList by the Department property of each Employee object.
e => e.Department is a lambda expression where e represents each Employee in the list. The lambda specifies that the grouping should be done based on the Department property.
3. .Select(g => new
Explanation: This projects each group into a new anonymous object that contains three properties: Department, AverageSalary, and Employees.
g represents each group of employees formed by the GroupBy method.
4. { Department = g.Key,
Explanation: The Department property of the anonymous object is set to g.Key, which represents the department name for that group. In a grouping operation, Key is the value that was used to group the elements, in this case, the department name.
5. AverageSalary = g.Average(e => e.Salary),
Explanation: The AverageSalary property is set to the average of the Salary values of all employees in the current group.
g.Average(e => e.Salary) calculates the average salary for all employees in the group g.
6. Employees = g.OrderByDescending(e => e.Salary).ToList()
Explanation: The Employees property is set to a list of employees in the current group, ordered by their salary in descending order.
g.OrderByDescending(e => e.Salary) sorts the employees in the group by their salary in descending order.
.ToList() converts the sorted result into a list.
7. })
Explanation: This closes the anonymous object initializer.
8. .OrderByDescending(d => d.AverageSalary)
Explanation: This sorts the groups of employees by the AverageSalary property in descending order.
d => d.AverageSalary is a lambda expression where d represents each of the anonymous objects created in the Select method. The sorting is based on the AverageSalary.
9. .First();
Explanation: This takes the first element from the sorted result, which corresponds to the department with the highest average salary. Since the list is sorted in descending order of average salary, the first element will have the highest average salary.
10. Console.WriteLine($"Highest Average Salary: {departmentWithHighestAvgSalary.Department}");
Explanation: This prints the name of the department with the highest average salary. The department name is accessed through the Department property of the departmentWithHighestAvgSalary object.
11. foreach (var employee in departmentWithHighestAvgSalary.Employees)
Explanation: This loop iterates over each employee in the Employees list of the departmentWithHighestAvgSalary object.
var employee represents each Employee object in the list.
12. Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
Explanation: This prints the Name and Salary of each employee in the department, where the salary is formatted to two decimal places (:F2).
The $ sign before the string indicates string interpolation, which allows you to embed expressions like employee.Name and employee.Salary directly within the string.
 
 */