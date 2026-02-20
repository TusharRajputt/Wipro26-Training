using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamles
{
    internal class ArrayEx
    {
        static void Main()
        {
            int[] a = { 1, 2, 3 };
            try
            {
                a[10] = 5;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Size is Small...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
