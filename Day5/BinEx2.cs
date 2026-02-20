using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileExamles
{
    internal class BinEx2
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"c:/files/calc.txt",FileMode.Open,FileAccess.Read); 
            BinaryReader br = new BinaryReader(fs);
            int x = br.ReadInt32();
            int y = br.ReadInt32();
            br.Close();
            fs.Close();
            int sum = x + y;
            int sub = x - y;
            int mult = x * y;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Sub is {sub}");
            Console.WriteLine($"Mult is {mult}");
        }
    }
}
