using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    public class Training
    {
        private string privateStr = "Hello";
        public string publicStr = "World";
        protected string protectedStr = "Test";
        internal string internalStr = "Hi";
        internal protected string internalProtectedStr = "Who";

        public void Show()
        {
            Console.WriteLine(privateStr);
            Console.WriteLine(publicStr);
            Console.WriteLine(protectedStr);
            Console.WriteLine(internalStr);
            Console.WriteLine(internalProtectedStr);
        }
    }
}
