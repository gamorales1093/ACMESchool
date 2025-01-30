using ACMESchool.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Test
{
    public class StudentsTest
    {
        [Fact]
        public void ShouldThrowExceptionIfStudentIsUnderage()
        {
            // Arrange & Act
            var exception = Assert.Throws<ArgumentException>(() => new Student("John Doe", 17));

            // Assert
            Assert.Equal("Student must be an adult.", exception.Message);
        }

        // Prueba 2: Verificar que el estudiante se crea correctamente si es adulto
        [Fact]
        public void ShouldRegisterStudentIfAdult()
        {
            // Arrange & Act
            var student = new Student("Jane Doe", 18);

            // Assert
            Assert.Equal("Jane Doe", student.Name);
            Assert.Equal(18, student.Age);
        }
    }
}
