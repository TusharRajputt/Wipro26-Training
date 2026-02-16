using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    internal class Test : Training
    {
        public void Show()
        {
            Test test = new Test();
            Console.WriteLine(test.publicStr);
            Console.WriteLine(test.internalStr);
            Console.WriteLine(test.protectedStr);
            Console.WriteLine(test.internalProtectedStr);
        }
    }
}
