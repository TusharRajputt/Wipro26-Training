using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class DebitCard : IElectricity
    {
        public string Payment(double billAmount)
        {
            return $"You are Paying Payment using Debit Card Your Bill Amount {billAmount}";
        }
    }
}
