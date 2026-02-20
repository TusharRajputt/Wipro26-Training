using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Anonymous
    {
        public delegate void Show(string str);

        static void Main()
        {
            Show obj1 = delegate (string str)
            {
                Console.WriteLine("This is My First Anonymous Method...");
            };

            obj1("Kishore");

            Show obj2 = delegate (string str)
            {
                Console.WriteLine("Good Morning to " +str);
            };

            obj2("Uday");

            Show obj3 = delegate (string str)
            {
                Console.WriteLine("All the Best  " +str);
            };

            obj3("Yash");
        }
    }
}
