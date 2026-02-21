using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class SrpMain
    {
        static void Main()
        {
            Console.WriteLine("Hello");
            EmployDao dao = new EmployDao();
            dao.AddEmploy(new Employ(1, "Raj", 72333));
            Console.WriteLine(dao.ShowEmploy().Count);
            foreach(Employ employ in dao.ShowEmploy())
            {
                Console.WriteLine(employ);
            }
            Console.WriteLine(dao.ShowEmploy());
        }
    }
}
