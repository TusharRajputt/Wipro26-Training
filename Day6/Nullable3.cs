using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class Nullable3
    {
        static void Main()
        {
            int? x = null;
            int? y = 5622;
            int z = x ?? 5;
            Console.WriteLine(z);
            z = y ?? 7;
            Console.WriteLine(z);

        }
    }
}
