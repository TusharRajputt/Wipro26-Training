using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Factorial
    {
        public void Calc(int n)
        {
            int f = 1;
            int i = 1;
            while (i <= n) 
            {
                f=f*i;
                i++;

            }
            Console.WriteLine(f);
        }
        static void Main()
        {
            int n;
            Console.WriteLine("enter number to find factorial");
            n=Convert.ToInt32(Console.ReadLine());
            Factorial fact=new Factorial();
            fact.Calc(n);
        }
    }
}
