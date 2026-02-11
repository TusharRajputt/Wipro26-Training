using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld { 

    internal class Prog10
    {
    public double ConvertToF(double c)
    {
            double f = ((9 * c) / 5) + 32;
            return f;

    }

    static void Main() {
            double c;
            Console.WriteLine("Enter Celcius Value ");
            c=Convert.ToDouble(Console.ReadLine()) ;
            Prog10 CtoF= new Prog10();
           
            Console.WriteLine("Fahrenheit value " + CtoF.ConvertToF(c));
        
        }
    }
}
