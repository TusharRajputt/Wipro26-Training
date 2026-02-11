using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Array1
    {
        public void Show()
        {
            Console.WriteLine("Enter the Size of array");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr =new int[n];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Displaying array");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }





        static void Main()
        {
            Array1 ar=new Array1();
            ar.Show();

        }
    }
}
