using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class SortingExample
    {
        static void Main()
        {
            string[] names = { "Tushar", "Aman", "Uday", "Pranav", "Aman", "Harsh", "Kabir" };

            Array.Sort(names);

            Console.WriteLine("Names after Sorting...");
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
