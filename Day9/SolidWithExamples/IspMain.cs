using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class IspMain
    {
        static void Main()
        {
            Induja induja = new Induja();
            induja.Name();
            induja.PaymentDetails();

            Sourav sourav = new Sourav();
            sourav.Name();
            sourav.PaymentDetails();
            sourav.PfDetails();
            sourav.PaySlips();
        }
    }
}
