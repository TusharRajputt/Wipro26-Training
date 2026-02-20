using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoProject
{
    class Demo
    {
        public void ShowMessage(string name)
        {
            lock (this)
            {
                Console.Write($"Hello {name}");
                Thread.Sleep(1000);
                Console.WriteLine(" How are You...");
            }
        }
    }
    internal class SyncEx
    {
        Demo demo;
        SyncEx( Demo demo )
        {
            this.demo = demo;
        }

        public void Aman()
        {
            demo.ShowMessage("Aman");
        }

        public void Tushar()
        {
            demo.ShowMessage("Tushar");
        }

        public void Kishore()
        {
            demo.ShowMessage("Kishore");
        }

        static void Main()
        {
            Demo demo = new Demo();
            SyncEx syncEx = new SyncEx(demo);

            ThreadStart th1 = new ThreadStart(syncEx.Aman);
            ThreadStart th2 = new ThreadStart(syncEx.Kishore);  
            ThreadStart th3 = new ThreadStart(syncEx.Tushar);

            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);
            Thread t3 = new Thread(th3);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}