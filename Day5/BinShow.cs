using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamles
{
    internal class BinShow
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"c:/files/all.txt",
                FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
           
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadBoolean());
            br.Close();
            fs.Close();
        }
    }
}
