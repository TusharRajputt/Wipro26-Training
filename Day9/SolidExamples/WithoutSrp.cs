using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidExamples
{
    class Employ
    {
        private int empno;
        private String name;
        private double basic;

        static List<Employ> employList;

        static Employ() 
        {
		    employList = new List<Employ>();
	    }
	
	public List<Employ> ShowEmploy()
        {
            return employList;
        }

        public String AddEmploy(Employ employ)
        {
            employList.Add(employ);
            return "Employ Record Added...";
        }

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

    internal class WithoutSrp
    {
       
        static void Main()
        {
            Employ e1 = new Employ(1, "Ram", 94923.33);
            e1.AddEmploy(e1);
            Console.WriteLine(e1);

        }
    }
}
