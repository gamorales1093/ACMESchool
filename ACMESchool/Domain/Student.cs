using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Core.Models
{
    public class Student
    {
        public string Name { get; }
        public int Age { get; }

        public Student(string name, int age)
        {
            if (age < 18)
                throw new ArgumentException("Student must be an adult.");

            Name = name;
            Age = age;
        }
    }
}
