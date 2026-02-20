using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace FileExamles
{
    internal class NumberZeroException : ApplicationException
    {
        public NumberZeroException(string error) : base(error) { }
    }
}
