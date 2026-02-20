using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    interface ITest1
    {
        void Show();
    }

    interface ITest2
    {
        void Show();
    }

    interface ITest3
    {
        void Show();
    }

    class Data : ITest1, ITest2, ITest3
    {
        void ITest1.Show()
        {
            Console.WriteLine("Show from Interface One...");
        }

        void ITest2.Show()
        {
            Console.WriteLine("Show From Interface Two...");
        }

        void ITest3.Show()
        {
            Console.WriteLine("Show From Interface Three...");
        }
    }
    internal class Quiz
    {
        static void Main()
        {
            ITest1 obj1 = new Data();
            ITest2 obj2 = new Data();
            ITest3 obj3 = new Data();

            obj1.Show();
            obj2.Show();
            obj3.Show();
        }
    }
}
