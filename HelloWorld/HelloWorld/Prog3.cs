using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Prog3
    {
        static void Main()
        {
            string name;
            string city;
            string company;
            Console.WriteLine("Enter your name:");
            name=Console.ReadLine();
            Console.WriteLine("Enter your city:");
            city=Console.ReadLine();
            Console.WriteLine("Enter your company:");
            company=Console.ReadLine();
            Console.WriteLine("Your name is: "+name);
            Console.WriteLine("Your city is: "+city);
            Console.WriteLine("Your company is: " + company);
        }
    }
}
