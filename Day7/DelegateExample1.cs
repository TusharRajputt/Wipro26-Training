using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class DelegateExample1
    {
        public delegate void MyDelegate();

        public static void Show()
        {
            Console.WriteLine("This is My First delegate Example...");
        }

        static void Main()
        {
            MyDelegate obj = new MyDelegate(Show);
            obj();
        }
    }
}
