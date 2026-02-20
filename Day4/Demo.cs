using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    internal class Demo : IOne, ITwo
    {
        public void Email()
        {
            Console.WriteLine("Email from Demo Class");
        }

        public void Name()
        {
            Console.WriteLine("Name from Demo Class...");
        }
    }
}
