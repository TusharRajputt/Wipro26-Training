using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class NameComparator : IComparer<Employ>
    {
        public int Compare(Employ x, Employ y)
        {
            return y.Name.CompareTo(x.Name);
        }
    }
}
