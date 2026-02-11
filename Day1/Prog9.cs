using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog9
    {
        static void Main()
        {
            int x = 10;
            int y = x++ + x++ + ++x + x++ + ++x;
            Console.WriteLine(y);
        }
    }
}
 