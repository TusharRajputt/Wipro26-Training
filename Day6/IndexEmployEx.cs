using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class IndexEmployEx
    {
        Employ[] arr = new Employ[5];

        public Employ this[int i]
        {
            get { return arr[i]; }
            set
            {
                arr[i] = value;
            }
        }
        static void Main()
        {
            IndexEmployEx obj = new IndexEmployEx();
            obj[0] = new Employ { Empno = 1, Name = "Yash", Basic = 994222 };
            obj[1] = new Employ { Empno = 2, Name = "Bhavya", Basic = 92224 };
            obj[2] = new Employ { Empno = 3, Name = "Abhishek", Basic = 92244 };
            obj[3] = new Employ { Empno = 4, Name = "Ashwin", Basic = 89422 };
            obj[4] = new Employ { Empno = 5, Name = "Anshual", Basic = 78844 };

            foreach (Employ v in obj.arr)
            {
                Console.WriteLine(v);
            }

        }
    }
}
