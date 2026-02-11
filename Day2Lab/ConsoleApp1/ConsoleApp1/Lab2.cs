using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lab2
    {
        public void Show()
        {
            int[] arr = new int[10] { 22, 52, 11, 10, 12, 22, 32, 12, 34, 43 };
           
            int[] a = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]  );

              
            }
            Console.WriteLine("\n");
            foreach (int i in a) {
                Console.WriteLine(i);
            }
        }

        static void Main()
           {
            Lab2 a = new Lab2();
            a.Show();
            }
    }
}
