using ACMESchool.Core.Application;
using ACMESchool.Core.Domain;
using ACMESchool.Core.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Test
{
    public class EnrollmentTests
    {
        [Fact]
        public void ShouldEnrollStudentIfPaymentIsSuccessful()
        {
            // Arrange
            var student = new Student("John", 20);
            var course = new Course("Math 101", 100m, DateTime.Now, DateTime.Now.AddMonths(2));
            var paymentGateway = new Mock<IPaymentGateway>();
            paymentGateway.Setup(p => p.ProcessPayment(student, 100m)).Returns(true);

            var enrollment = new Enrollment(paymentGateway.Object);

            // Act
            var result = enrollment.EnrollStudent(course, student);

            // Assert
            Assert.True(result);
            Assert.Contains(student, course.EnrolledStudents);
        }

        [Fact]
        public void ShouldNotEnrollStudentIfPaymentFails()
        {
            // Arrange
            var student = new Student("John", 20);
            var course = new Course("Math 101", 100m, DateTime.Now, DateTime.Now.AddMonths(2));
            var paymentGateway = new Mock<IPaymentGateway>();
            paymentGateway.Setup(p => p.ProcessPayment(student, 100m)).Returns(false);

            var enrollment = new Enrollment(paymentGateway.Object);

            // Act
            var result = enrollment.EnrollStudent(course, student);

            // Assert
            Assert.False(result);
            Assert.Empty(course.EnrolledStudents);
        }

        [Fact]
        public void ShouldThrowExceptionIfStudentIsUnderage()
        {
            // Arrange
            var student = new Student("John", 17);
            var course = new Course("Math 101", 100m, DateTime.Now, DateTime.Now.AddMonths(2));
            var paymentGateway = new Mock<IPaymentGateway>();
            var enrollment = new Enrollment(paymentGateway.Object);


            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => enrollment.EnrollStudent(course, student));

            // Verificamos que el mensaje de la excepción sea el esperado (opcional)
            Assert.Equal("Student must be an adult.", exception.Message);
        }

       
    }

}
