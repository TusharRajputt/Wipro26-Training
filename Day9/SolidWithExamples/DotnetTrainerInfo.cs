using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWithExamples
{
    internal class DotnetTrainerInfo : ITrainerData
    {
        public void City()
        {
            Console.WriteLine("City is Hyderabad...");
        }

        public void Email()
        {
            Console.WriteLine("Email is prassucp@gmail.com");
        }

        public void Name()
        {
            Console.WriteLine("Trainer Name is Prasanna Pappu...");
        }
    }
}
