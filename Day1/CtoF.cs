using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CtoF
    {
        public double ConvertToF(double c)
        {
            double f =((9 * c) / 5)+ 32;
            return f;

        }


        public double ConvertToC(double f) 
        {
            double c = (f - 32) *5/9;
            return c;

        }
        static void Main()
        {
          
            Console.WriteLine("Enter Celcius: "); 
 double  c=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Fahrenheit");
            double f= Convert.ToDouble(Console.ReadLine());
            CtoF ctof=new CtoF();
            Console.WriteLine("fahrenheit :" + ctof.ConvertToF(c));
            Console.WriteLine("celcius" + ctof.ConvertToC(f));

        }
        
    }
   
}
