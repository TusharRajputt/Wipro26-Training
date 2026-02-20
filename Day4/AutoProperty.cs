using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    class Employee
    {
        public int Empno { get; set; } 
        public string Name { get; set; }
        public double Salary { get; set;}

        public override string ToString()
        {
            return $"Employ No {Empno} Employ Name {Name} Salary {Salary}";
        }
    }
    internal class AutoProperty
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            emp1.Empno = 1;
            emp1.Name = "Aman";
            emp1.Salary = 88323;

            Employee emp2 = new Employee();
            emp2.Empno = 2;
            emp2.Name = "Uday";
            emp2.Salary = 90032;

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

        }
    }
}
