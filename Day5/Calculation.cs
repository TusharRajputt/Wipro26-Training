using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamles
{
    internal class Calculation
    {
        public void Calc(int a, int b)
        {
            if (a < 0 || b < 0)
            {
                throw new NegativeException("Negative Nos Not Allowed...");
            } else if (a ==0 || b == 0)
            {
                throw new NumberZeroException("Zero is Invalid Value...");
            } 
            else
            {
                int res = a + b;
                Console.WriteLine($"Sum is {res}");
                res = a - b;
                Console.WriteLine($"Sub is {res}");
                res = a * b;
                Console.WriteLine($"Mult is {res}");
            }
        }
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers   ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation calc = new Calculation();
            try
            {
                calc.Calc(a, b);
            }
            catch(NumberZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NegativeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
