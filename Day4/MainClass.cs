using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    public class MainClass
    {
        private string privateStr = "Welcome";
        protected string protectedStr = "Hello";
        internal string internalStr = "Interns";
        internal protected string internalProtectedStr = "Ipaddres";
        public string publicStr = "Wipro";

        public void Show()
        {
            Console.WriteLine(privateStr);
            Console.WriteLine(publicStr);
            Console.WriteLine(internalStr);
            Console.WriteLine(internalProtectedStr);
            Console.WriteLine(protectedStr);
        }
    }
}
