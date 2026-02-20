using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class DictEx2
    {
        static string GetValue(Dictionary<int,string> dict, int key)
        {
            string res;
            dict.TryGetValue(key, out res);
            return res;
        }
        static void Main()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Uday");
            students.Add(2, "Yash");
            students.Add(3, "Irfan");
            students.Add(4, "Akarsh");
            students.Add(5, "Abhishek");
            string res;
            res = GetValue(students, 2);
            Console.WriteLine(res);
        }
    }
}
