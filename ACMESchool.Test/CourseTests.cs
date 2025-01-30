using ACMESchool.Core.Application;
using ACMESchool.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Test
{
    public class CourseTests
    {
        [Fact]
        public void ShouldReturnCoursesInDateRange()
        {
            // Arrange
            var courses = new List<Course>
            {
              new Course("Math 101", 100, new DateTime(2025, 1, 1), new DateTime(2025, 3, 31)),
              new Course("English 101", 100, new DateTime(2025, 4, 1), new DateTime(2025, 6, 30)),
              new Course("History 101", 100, new DateTime(2025, 2, 1), new DateTime(2025, 4, 30))
            };

            var courseService = new CourseManagementService(courses);

            var startDate = new DateTime(2025, 2, 1);
            var endDate = new DateTime(2025, 4, 30);

            // Act
            var result = courseService.GetCoursesInDateRange(startDate, endDate);

            // Assert
            Assert.Single(result);  
            Assert.Contains(result, c => c.Name == "History 101");
        }
    }
}
