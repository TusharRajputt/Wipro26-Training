using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();
            Console.WriteLine(operations.PosNeg(5));
            Console.WriteLine(operations.EvenOdd(4));
            Console.WriteLine(operations.Voting(18));
            string s = "Hello";
            Console.WriteLine(s.ShowName("Aman"));
        }
    }
}
