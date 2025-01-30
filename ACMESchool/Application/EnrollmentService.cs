using ACMESchool.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Core.Application
{
    public class EnrollmentService
    {
        private readonly Enrollment _enrollment;

        public EnrollmentService(Enrollment enrollment)
        {
            _enrollment = enrollment;
        }

        public bool EnrollStudentInCourse(Course course, Student student)
        {
            return _enrollment.EnrollStudent(course, student);
        }
    }
}
