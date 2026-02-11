using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prime
    {
        public void Show(int x)
        {
            bool IsPrime = true;
          if(x<=1)
            
                IsPrime = false;
            
            else
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0) 
                    {
                        IsPrime = false;
                        break;
                    }
                }
                
            }
            if (IsPrime == true)
            {
                Console.WriteLine("its prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }


        static void Main()
        {
            int x;
            Console.WriteLine("Enter a number to check its prime or not");
            x = Convert.ToInt32(Console.ReadLine());
            Prime prime = new Prime();
            prime.Show(x);
            

               
                }
            }



        
    }
