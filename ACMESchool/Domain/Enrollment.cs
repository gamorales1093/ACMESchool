using ACMESchool.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Core.Models
{
    public class Enrollment
    {
        private readonly IPaymentGateway _paymentGateway;

        public Enrollment(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public bool EnrollStudent(Course course, Student student)
        {
            // Verificar si el estudiante es adulto
            if (student.Age < 18)
            {
                throw new ArgumentException("Student must be an adult.");
            }

            // Verificar si el pago se realizó correctamente
            if (!_paymentGateway.ProcessPayment(student, course.RegistrationFee))
            {
                return false;
            }

            // Inscribir al estudiante en el curso
            course.EnrolledStudents.Add(student);  // Aquí directamente agregamos al estudiante.
            return true;
        }
    }
}
