using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileExamles
{
    internal class ReadFileEx
    {
        static void Main()
        {
            FileStream fs = new FileStream(@"c:/files/Program.cs",
                FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs); 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str;
            do
            {
                str = sr.ReadLine();
                Console.WriteLine(str);
            } while (str != null);
            sr.Close();
            fs.Close();
        }
    }
}
