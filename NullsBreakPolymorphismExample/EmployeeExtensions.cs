using System;

namespace NullsBreakPolymorphismExample
{
    public static class EmployeeExtensions
    {
        public static string ToDisplayString(this Employee employee)
        {
            if (employee != null)
                return String.Format("{0} {1}: {2} days", employee.FirstName, employee.LastName, employee.TenureInDays());

            return "Unknown employee";
        }
    }
}
