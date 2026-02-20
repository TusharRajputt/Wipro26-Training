using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class FdEx4
    {
        Func<int> Commission = delegate ()
        {
            return 1000;
        };
        static void Main()
        {
            Console.WriteLine(new FdEx4().Commission());
        }

    }
}
