using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Core.Models
{
    public class Course
    {
        public string Name { get; }
        public decimal RegistrationFee { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public List<Student> EnrolledStudents { get; } = new List<Student>();

        public Course(string name, decimal registrationFee, DateTime startDate, DateTime endDate)
        {
            Name = name;
            RegistrationFee = registrationFee;
            StartDate = startDate;
            EndDate = endDate;
        }

        public bool IsWithinDateRange(DateTime start, DateTime end)
        {
            return StartDate >= start && EndDate <= end;
        }
    }
}
