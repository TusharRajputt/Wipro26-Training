using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileExamles
{
    internal class BinEx1
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"c:/files/calc.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(12);
            bw.Write(15);
            bw.Close();
            fs.Close();
            Console.WriteLine("Numbers Stored in File...");
        }
    }
}
