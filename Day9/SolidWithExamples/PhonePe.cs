using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class PhonePe : IElectricity
    {
        public string Payment(double billAmount)
        {
            return $"You are Paying Payment using PhonePe Your Bill Amount {billAmount}";
        }
    }
}
