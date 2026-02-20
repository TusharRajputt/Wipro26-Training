using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class FunctionalDelegateExample3
    {
        public static int ShowStatus(string type)
        {
            if (type.Equals("Yearly"))
            {
                return 1;
            }
            else if (type.Equals("Half-Yearly"))
            {
                return 2;
            }
            else if (type.Equals("Quarterly"))
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        static void Main()
        {
            Func<string, int> result = ShowStatus;
            Console.WriteLine(result("Quarterly"));
        }
    }
}
