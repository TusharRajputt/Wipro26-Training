using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsCalculation;

namespace OopsExamples
{
    internal class CalcMain
    {
        static void Main()
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.Sum(12,4));
            Console.WriteLine(calculation.Sub(12,4));
            Console.WriteLine(calculation.Mult(12,4));
        }
    }
}
