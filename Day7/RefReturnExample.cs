using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class RefReturnExample
    {

        public ref string GetResult(string[] names)
        {
             string[] arrResult = { "Not Found", "Found" };
            ref string result = ref arrResult[0];

            foreach (string name in names)
            {
                if (name.Equals("Uday"))
                {
                    result = arrResult[1];
                    return ref result;
                }
            }
            return ref result;
        }
        static void Main()
        {
            string[] students = { "Aman",  "Irfan", "Akarsh", "Karthik" };
            ref string result = ref new RefReturnExample().GetResult(students);
            Console.WriteLine(result);

        }
    }
}
