using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLibrary
{
    internal class Demo
    {
        public void Display()
        {
            Training training = new Training();
            Console.WriteLine(training.publicStr);
            Console.WriteLine(training.internalStr);
            Console.WriteLine(training.internalProtectedStr);
            //Console.WriteLine(training.pro);
        }
    }
}
