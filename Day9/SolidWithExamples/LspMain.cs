using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class LspMain
    {
        static void Main()
        {
            Training[] arr = new Training[]
            {
                new Tushar(), 
                new Simha(), 
                new Vinay()
            };

            foreach(Training training in arr)
            {
                training.ShowInfo();
            }
        }
    }
}
