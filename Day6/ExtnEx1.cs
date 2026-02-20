using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsCalculation;

namespace OopsExamples
{
    internal static class ExtnEx1
    {
        public static string ShowName(this string str, string name)
        {
            return "This is String extension Method " + name;
        }
        public static int Mult(this Calculation calc, int a, int b)
        {
            return a * b;
        }
        public static string Voting(this Operations ob, int age)
        {
            if (age >= 18)
            {
                return "You Can Vote...";
            }
            else
            {
                return "You Cannot Vote...";
            }
        }
    }
}
