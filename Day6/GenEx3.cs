using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    class Data<T,V>
    {
        T t;
        V v;

        public Data(T t, V v)
        {
            this.t = t;
            this.v = v;
        }

        public override string ToString()
        {
            return $"First Value {t} Second Value {v}";
        }
    }
    internal class GenEx3
    {
        static void Main()
        {
            Data<int, string> obj1 = new Data<int, string>(1, "Prasanna");
            Console.WriteLine(obj1);
            Data<string, double> obj2 = new Data<string, double>("Rajesh", 84834.22);
            Console.WriteLine(obj2);
        }
    }
}
