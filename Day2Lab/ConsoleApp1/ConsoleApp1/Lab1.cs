using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lab1
    {
        public void ReverseAlter(String s)
        {
            String[] words = s.Split(' ');
            String result = "";
             for(int i=0;i<words.Length; i++)
            {
                String w = words[i];
                string rev = "";
                if (i % 2 == 1)
                {
                   for (int j = w.Length - 1; j >= 0; j--)
                    {
                        rev = rev + w[j];
                    }
                    result = result + rev + " ";
                }
                else
                {
                    result = result + w + " ";
                }
            }
           

             Console.WriteLine(result.Trim());  

        }
        static void Main()
        {

            Console.WriteLine("enter  sentence:");
            String s= Console.ReadLine();
            Lab1 l= new Lab1(); 
            l.ReverseAlter(s);


        }
    }
}
