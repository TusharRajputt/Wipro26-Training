using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class TupleExample2
    {
        static void Main()
        {
            ShowEmployTuple((1, "Kishore", 84823.33));
            ShowEmployTuple((2, "Vinay", 99992.34));
            ShowEmployTuple((3, "Yash", 99722.33));
        }

        static void ShowEmployTuple((int, string,double) employ)
        {
            Console.WriteLine($"Employ No {employ.Item1} Employ Name {employ.Item2} " +
                $"  Salary {employ.Item3}");
        }
    }
}
