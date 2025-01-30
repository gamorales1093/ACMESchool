using ACMESchool.Core.Domain;
using ACMESchool.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMESchool.Test.Mocks
{
    public class MockPaymentGateway : IPaymentGateway
    {
        public bool ProcessPayment(decimal amount)
        {
            // Simula el procesamiento de un pago exitoso
            return amount > 0;  // Asumimos que el pago es exitoso si la cantidad es mayor que 0
        }

        public bool ProcessPayment(Student student, decimal amount)
        {
            return amount > 0;

        }
    }
}
