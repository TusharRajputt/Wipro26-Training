using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class EmployDao : IEmployDao
    {
        static List<Employ> employList;

        static EmployDao()
        {
            employList = new List<Employ>()
            {
                new Employ(1,"Abhishek",83233),
                new Employ(2,"Tushar",90011),
                new Employ(3,"Harsh",98111),

            };
        }
        public string AddEmploy(Employ employ)
        {
           employList.Add(employ);
            return "Employ Record Inserted...";
        }

        public List<Employ> ShowEmploy()
        {
            return employList;
        }
    }
}
