using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class MultiCastEx2
    {
        public delegate void MultiCast(string s);

        public static void Greeting(string s)
        {
            Console.WriteLine("Good Morning..." +s);
        }

        public static void Exam(string s)
        {
            Console.WriteLine("Mostly Exam Happens on Tomorrow Mr." +s);
        }

        public static void Wishes(string s)
        {
            Console.WriteLine($"Hello {s} All the Best for Exam");
        }

        static void Main()
        {
            string s = "Tushar";
            MultiCast obj = new MultiCast(Greeting);
            obj += new MultiCast(Exam);
            obj += new MultiCast(Wishes);
            obj(s);
        }
    }
}
