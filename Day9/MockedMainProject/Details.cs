using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockedMainProject
{
    public class Details : IDetails
    {
        public string Greeting()
        {
            return "Good Morning to All...";
        }

        public string ShowCompany()
        {
            return "Hi Company is Wipro Online Batch...";
        }

        

        public string ShowStudent()
        {
            return "Student Name is Aman...";
        }
    }
}
