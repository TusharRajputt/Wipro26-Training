using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class FdEx3
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public int Mult(int x, int y)
        {
            return x * y;
        }

        static void Main()
        {
            Func<int, int, int> result1 = new FdEx3().Sum;
            int res = result1(12, 5);
            Console.WriteLine("Sum is  " + res);

            Func<int, int, int> result2 = new FdEx3().Sub;
            res = result2(12, 5);
            Console.WriteLine("Sub is  " + res);

            Func<int, int, int> result3 = new FdEx3().Mult;
            res = result3(12, 5);
            Console.WriteLine("Mult is  " + res);

        }


    }
}
