using System;

namespace NullsBreakPolymorphismExample
{
    public class Employee
    {
        public static Employee NotFound = new Employee() { FirstName = "No First Name", LastName = "No Last Name", DateHired = DateTime.MinValue };

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime? DateTerminated { get; set; }

        public int TenureInDays(DateTime? currentDate = null)
        {
            DateTime endDate = currentDate ?? DateTime.Now;
            if (DateTerminated.HasValue)
            {
                endDate = DateTerminated.Value;
            }
            return (endDate - DateHired).Days;
        }

        public override string ToString() => (this == NotFound ?
                        "Unknown employee" :
                        $"{FirstName} {LastName}: {TenureInDays()} days");
    }
}
