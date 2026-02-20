using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    internal class MainProg1
    {
        static void Main()
        {
            ITraining[] arr = new ITraining[]
            {
                new Ganesh(), new Yash(), new Aryan()
            };

            foreach(ITraining training in arr)
            {
                training.Name();
                training.Email();
            }
        }
    }
}
