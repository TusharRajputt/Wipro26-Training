using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class BasicComparator : IComparer<Employ>
    {
        public int Compare(Employ x, Employ y)
        {
            if (x.Basic >= y.Basic)
            {
                return -1;
            }
            return 1;
        }
    }
}
