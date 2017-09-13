﻿using System;
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
                Console.WriteLine("{0} {1}: {2} days", employee.FirstName, employee.LastName, employee.TenureInDays());
            }
            Console.ReadLine();
        }

        private static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee()
            {
                FirstName = "Steve",
                LastName = "Smith",
                DateHired = new DateTime(2014, 6, 1)
            });
            employees.Add(new Employee()
            {
                FirstName = "John",
                LastName = "Doe",
                DateHired = new DateTime(2015, 6, 1),
                DateTerminated = new DateTime(2015, 7, 1)
            });
            employees.Add(GetEmployee());
            return employees;
        }

        private static Employee GetEmployee()
        {
            return null;
        }
    }
}
