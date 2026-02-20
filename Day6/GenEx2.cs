using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class GenEx2
    {
        static void Main()
        {
            List<string> names = new List<string>();
            names.Add("Tushar");
            names.Add("Kishore");
            names.Add("Manoj");
            names.Add("Dinesh");
            //names.Add(12);
            Console.WriteLine("Names are");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
