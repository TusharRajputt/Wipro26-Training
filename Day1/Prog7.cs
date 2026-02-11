using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog7
    {
        static void Main()
        {
            int x = 10;
            Console.WriteLine(x++); 
            // x actual value is 10 but in memory its 11

            Console.WriteLine(++x);
            // the memory increments hence 12


        }
    }
}
