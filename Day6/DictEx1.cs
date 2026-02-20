using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class DictEx1
    {
        static void Main()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Uday");
            students.Add(2, "Yash");
            students.Add(3, "Irfan");
            students.Add(4, "Akarsh");
            students.Add(5, "Abhishek");

            foreach(KeyValuePair<int,string> k in  students) 
            {
                Console.WriteLine($"Key ${k.Key}, Value : ${k.Value}");
            }

        }
    }
}
