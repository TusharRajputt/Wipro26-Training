using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog3
    {
        static void Main()
        {
            String name;
            String company;
            String city;
            String country;
            Console.WriteLine("Enter your Name ");
            name= Console.ReadLine();
            Console.WriteLine("Enter your Company ");
            company= Console.ReadLine();
            Console.WriteLine("Enter your City ");
            city= Console.ReadLine();
            Console.WriteLine("Enter your Country ");
            country= Console.ReadLine();


            Console.WriteLine("Name " + name);
            Console.WriteLine("Company " + company);
            Console.WriteLine("City " + city);
            Console.WriteLine("Country " + country);
        }
    }
}
