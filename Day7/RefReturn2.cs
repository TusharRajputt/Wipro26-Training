using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class RefReturn2
    {
        public ref string ShowMaritalInfo(int[] scode)
        {
            string[] arrResult = { "Unknowns", "Married", "Unmarried" };
            ref string result = ref arrResult[1];

            foreach (int s in scode)
            {
                if (s==0)
                {
                    result = arrResult[1];
                } else if (s==1)
                {
                    result = arrResult[2];
                }
            }
            return ref result;
        }

        static void Main()
        {
            int[] statusCode = { 0, 1, 2 };
            ref string res = ref new RefReturn2().ShowMaritalInfo(statusCode);
            Console.WriteLine(res);

        }
    }
}
