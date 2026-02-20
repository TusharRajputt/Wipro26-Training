using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class IndexerEx
    {
        string[] names = new string[5];

        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
        static void Main()
        {
            IndexerEx indexerEx = new IndexerEx();
            indexerEx[0] = "Karthik";
            indexerEx[1] = "Vijay";
            indexerEx[2] = "Vinay";
            indexerEx[3] = "Shaik";
            indexerEx[4] = "Uday";

            foreach (object o in indexerEx.names)
            {
                Console.WriteLine(o);
            }
        }
    }
}
