using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockedMainProject
{
    internal class EmployDao
    {
        static List<Employ> employList;
        static EmployDao()
        {
            employList = new List<Employ>
            {
                new Employ{Empno = 1, Name = "Tushar", Basic=90234.22},
                new Employ{Empno = 2, Name = "Abhishek", Basic=91112.22},
                new Employ{Empno = 3, Name = "Kishore", Basic=98811.22},
                new Employ{Empno = 4, Name = "Kabir", Basic=90012.22},
                new Employ{Empno = 5, Name = "Vinay", Basic=98711.22},
                new Employ{Empno = 6, Name = "Ritwik", Basic=90111.22},
            };
        }
        public Employ SearchEmploy(int empno)
        {
            Employ employ = employList.Where(x => x.Empno == empno).FirstOrDefault();
            return employ;
        }

        public List<Employ> ShowEmploy()
        {
            return employList;
        }
    }
}
