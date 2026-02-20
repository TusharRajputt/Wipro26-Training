using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileExamles
{
    internal class ReadEmploy
    {
        static void Main()
        {
            FileStream fs = new FileStream("c:/files/employdata.txt",FileMode.Open,FileAccess.Read);   
            BinaryFormatter formatter = new BinaryFormatter();
            Employ employ = (Employ)formatter.Deserialize(fs);
            Console.WriteLine(employ);
            fs.Close();
        }
    }
}
