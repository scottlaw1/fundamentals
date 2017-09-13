using System;

namespace NullsBreakPolymorphismExample
{
    public class Employee
    {
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
    }
}
