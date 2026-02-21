using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    public class Employ
    {
        private int empno;
        private String name;
        private double basic;

        public Employ() { }

        public Employ(int empno, string name, double basic)
        {
            this.empno = empno;
            this.name = name;
            this.basic = basic;
        }

        public override string ToString()
        {
            return $"Employ No {empno} Employ Name {name} Salary {basic}";
        }
    }
}
