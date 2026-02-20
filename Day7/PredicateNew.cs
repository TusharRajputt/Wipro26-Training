using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class PredicateNew
    {

        public static bool Test(string company)
        {
            if (company.Equals("Wipro"))
            {
                return true;
            }
            return false;
        }
        public static bool Result(int score)
        {
            if (score >= 35)
            {
                return true;
            }
            return false;
        }

        static void Main()
        {
            Predicate<int> res = Result;
            Console.WriteLine(res(35));
            Console.WriteLine(res(11));

            Predicate<string> res1 = Test;
            Console.WriteLine(res1("Wipro"));
        }
    }
}
