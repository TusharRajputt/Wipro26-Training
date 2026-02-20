using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EventExamle
    {
        public delegate void EventExample();
        public static event EventExample ShowName;

        public static void Abhishek()
        {
            Console.WriteLine("Hi I am Abhishek...");
        }

        public static void Kabir()
        {
            Console.WriteLine("Hi I am Kabir...");
        }

        public static void Harsh()
        {
            Console.WriteLine("Hi I am Harsh...");
        }

        public static void Uday()
        {
            Console.WriteLine("Hi I am Uday...");
        }

        public static void Execute(string name)
        {
            if (name.Equals("Harsh"))
            {
                ShowName = new EventExample(Harsh);
                ShowName.Invoke();
            }

            if (name.Equals("Kabir"))
            {
                ShowName = new EventExample(Kabir);
                ShowName.Invoke();
            }

            if (name.Equals("Uday"))
            {
                ShowName = new EventExample(Uday);
                ShowName.Invoke();
            }

            if (name.Equals("Abhishek"))
            {
                ShowName = new EventExample(Abhishek);
                ShowName.Invoke();
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter Name  ");
            string name = Console.ReadLine();
            Execute(name);
        }
    }
}
