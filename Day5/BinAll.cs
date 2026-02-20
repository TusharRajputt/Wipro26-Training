using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamles
{
    internal class BinAll
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"c:/files/all.txt", 
                FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(12);
            bw.Write("Tripathi");
            bw.Write(12.55);
            bw.Write(true);
            bw.Close();
            fs.Close();
            Console.WriteLine("Data Stored in File Successfully...");
        }
    }
}
