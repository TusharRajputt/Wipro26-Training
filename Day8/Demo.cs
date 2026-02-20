using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Demo
    {
        public bool EvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public int MinArray(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        public string SayHello()
        {
            return "Welcome to Nunit Testing...";
        }

        public int Max3(int a, int b, int c)
        {
            int m = a;
            if (m <b)
            {
                m = b;
            }
            if (m < c)
            {
                m = c;
            }
            return m;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
