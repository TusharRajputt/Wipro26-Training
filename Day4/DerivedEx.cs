using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    internal class DerivedEx : MainClass
    {
        public void Test()
        {
            DerivedEx derivedEx = new DerivedEx();
            Console.WriteLine(derivedEx.publicStr);
            Console.WriteLine(derivedEx.protectedStr);
            Console.WriteLine(derivedEx.internalStr);
            Console.WriteLine(derivedEx.internalProtectedStr);
        }
    }
}
