using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class Sourav : IEmployDetails, IAccountDetails
    {
        public void Name()
        {
            Console.WriteLine("Name is Sourav...");
        }

        public void PaymentDetails()
        {
            Console.WriteLine("Salary to be Paid to Your Account...");
        }

        public void PaySlips()
        {
            Console.WriteLine("Payslips are to be given...");
        }

        public void PfDetails()
        {
            Console.WriteLine("Pf Details shared after 1 month...");
        }
    }
}
