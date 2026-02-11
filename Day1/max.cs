using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class max
    {
        public void check(int x, int y, int z)
        {
            int m = x;
            if (m < y)
            {
                m = y;
            }
            if(m < z){
                    m = z;
                }
         Console.WriteLine(m);

            }


     static void Main()
            {
                int a, b, c;
                Console.WriteLine("Enter 3 numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                max max1 = new max();
                max1.check(a, b, c);

            }
        

    }
}
