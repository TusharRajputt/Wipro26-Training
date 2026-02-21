using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class NetBanking : IElectricity
    {
        public string Payment(double billAmount)
        {
            return $"You are Paying Payment using NetBanking  Your Bill Amount {billAmount}";
        }
    }
}
