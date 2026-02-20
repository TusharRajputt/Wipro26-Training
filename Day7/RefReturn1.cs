using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class RefReturn1
    {
        public ref int GetFirstOddNumber(int[] a)
        {
          for(int i=0;i<a.Length;i++)
            {
                if (a[i] %2==1)
                {
                    return ref a[i];
                }
            }
            throw new Exception("Not Found...");
        }
        static void Main()
        {
            int[] a = new int[] { 12, 2, 3, 4, 5, 6, 7, 8 };
            RefReturn1 obj = new RefReturn1();
            int res = obj.GetFirstOddNumber(a);
            Console.WriteLine("First Odd Number is  " +res);
        }
    }
}
