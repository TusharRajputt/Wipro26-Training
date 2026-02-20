using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class EmploySortExample
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>()
            {
                new Employ{Empno=1, Name="Shaik",Basic=90122},
                new Employ{Empno=2, Name="Vinay",Basic=82334},
                new Employ{Empno=3, Name="Pranav",Basic=89922},
                new Employ{Empno=4, Name="Yash",Basic=87771},
                new Employ{Empno=5, Name="Aman",Basic=99911},
                new Employ{Empno=6, Name="Neerav",Basic=90011}
            };
            employList.Sort(new NameComparator());
            foreach (Employ employ in employList)
            {
                Console.WriteLine(employ);
            }
            Console.WriteLine("Sort By Salary-Wise  ");
            employList.Sort(new BasicComparator());
            foreach (Employ employ1 in employList)
            {
                Console.WriteLine(employ1);
            }
        }
    }
}
