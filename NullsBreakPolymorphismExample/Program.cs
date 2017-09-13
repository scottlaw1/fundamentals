using System;
using System.Collections.Generic;

namespace NullsBreakPolymorphismExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = GetEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToDisplayString());
            }
            Console.ReadLine();
        }

        private static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>
            {
                new Employee()
                {
                    FirstName = "Steve",
                    LastName = "Smith",
                    DateHired = new DateTime(2014, 6, 1)
                },
                new Employee()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateHired = new DateTime(2015, 6, 1),
                    DateTerminated = new DateTime(2015, 7, 1)
                },
                GetEmployee()
            };
            return employees;
        }

        private static Employee GetEmployee()
        {
            return null;
        }
    }
}
