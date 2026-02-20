using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLibrary;

namespace SecondLibrary
{
    internal class Testing :MainClass
    {
        public void ShowInfo()
        {
            Testing testing = new Testing();
            Console.WriteLine(testing.publicStr);
            Console.WriteLine(testing.protectedStr);
            Console.WriteLine(testing.internalProtectedStr);
        }
    }
}
