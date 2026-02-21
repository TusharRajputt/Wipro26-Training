using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal interface IEmployDao
    {
        List<Employ> ShowEmploy();
        string AddEmploy(Employ employ);
    }
}
