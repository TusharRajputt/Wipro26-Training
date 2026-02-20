using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class TupleExample1
    {
        static (int empno, string name, double basic) EmployInfo()
        {
            return (empno: 1, name: "Tushar", basic: 84233);
        }
        static void Main()
        {
            var obj = EmployInfo();
            Console.WriteLine($"Employ No {obj.empno}");
            Console.WriteLine($"Employ Name {obj.name}");
            Console.WriteLine($"Basic {obj.basic}");
        }
    }
}
