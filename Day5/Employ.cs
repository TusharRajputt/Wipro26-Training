using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamles
{
    [Serializable]
    internal class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public string Desig { get; set; }
        public double Basic { get; set; }

        public override string ToString()
        {
            return $"Employ No {Empno} Name {Name} Dept {Dept} Desig {Desig} Salary {Basic}";
        }
    }
}
