using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class PredicateEx1
    {
        public static bool MaritalStatus(int status)
        {
           if (status == 0) {
                return false;
            }
            return true;
        }

        public static bool Check(string gender)
        {
            if (gender.ToUpper().Equals("MALE") || gender.ToUpper().Equals("FEMALE"))
            {
                return true;
            }
            return false;
        }


        static void Main()
        {
            Predicate<int> res1 = MaritalStatus;
            Console.WriteLine(res1(1));

            Predicate<string> res2 = Check;
            Console.WriteLine(res2("MALE"));
        }
    }
}
