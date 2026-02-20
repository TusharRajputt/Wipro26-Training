using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Operations
    {
        public string PosNeg(int n)
        {
            if (n >= 0)
            {
                return "Positive Number...";
            }
            else
            {
                return "Negative Number...";
            }
        }
        public string EvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                return "Even Number...";
            }
            else
            {
                return "Odd Number...";
            }
        }
    }
}
