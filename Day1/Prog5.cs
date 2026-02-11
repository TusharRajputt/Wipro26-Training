using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog5
    {
        // Addition, Substraction & Multiplication
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter Two Numbers:");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            #region Addition
            c = a + b;
            Console.WriteLine("Sum: "+c);
            #endregion Addition
            #region Substraction
            c = a - b;
            Console.WriteLine("Subs: " + c);
            #endregion Substraction
            #region Multiplication
            c = a * b;
            Console.WriteLine("Multi: " + c);
            #endregion Multiplication
        }
    }
}
