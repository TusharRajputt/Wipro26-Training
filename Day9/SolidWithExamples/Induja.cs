using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class Induja : IEmployDetails
    {
        public void Name()
        {
            Console.WriteLine("Name is Induja...");
        }

        public void PaymentDetails()
        {
            Console.WriteLine("Payment to be Paid with Deducting TDS...");
        }
    }
}
