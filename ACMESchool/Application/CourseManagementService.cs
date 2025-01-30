using ACMESchool.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Core.Application
{
    public class CourseManagementService
    {
       private readonly List<Course> _courses;

    public CourseManagementService(List<Course> courses)
    {
        _courses = courses;
    }

    public List<Course> GetCoursesInDateRange(DateTime startDate, DateTime endDate)
    {
            return _courses
                   .Where(c => c.StartDate >= startDate && c.EndDate <= endDate)
                   .ToList();
        }
    }
}
