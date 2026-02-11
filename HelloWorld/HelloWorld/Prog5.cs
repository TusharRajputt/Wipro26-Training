using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Prog5
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("enter two numbers ");
        

            a=Convert.ToInt32(Console.ReadLine());
           
            b=Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("a+b=" + c);
            c = a - b;
            Console.WriteLine("a-b=" + c);
            c = a * b;
            Console.WriteLine("a x b=" +c);
        }
    }
}
