using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Prog8
    {
        public void Calc(double radius)
        {
            double area, circ;
            area = Math.PI * Math.Pow(radius, 2);
            circ = Math.PI * 2 * radius;
            Console.WriteLine("Area of Circle " +area);
            Console.WriteLine("Circumference of cicle " + circ);
        }

        static void Main() {
            double radius;
            Console.WriteLine("Enter Radius: ");
            radius =Convert.ToDouble(Console.ReadLine());
            Prog8 circleProg = new Prog8();
            circleProg.Calc(radius);
        
        }

    }
}
