using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsExamples
{
    internal class UseAuth
    {
        static void Main()
        {
            Dictionary<string,string> userData = new Dictionary<string,string>();
            userData.Add("Akarsh", "Prasad");
            userData.Add("Adhiraj", "Deshkukh");
            userData.Add("Aryan", "Sharma");
            userData.Add("Neerav", "Satone");
            userData.Add("Vinay", "Dyaga");
            string user, pwd;
            Console.WriteLine("Enter UserName and Password   ");
            user = Console.ReadLine();
            pwd = Console.ReadLine();
            string res;
            userData.TryGetValue(user, out res); 
            if (res.Equals(pwd))
            {
                Console.WriteLine("Correct Credentials");
            }
            else
            {
                Console.WriteLine("Invalid Credentials...");
            }
        }
    }
}
