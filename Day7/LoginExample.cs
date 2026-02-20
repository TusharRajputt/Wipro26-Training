using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class LoginExample
    {
        public delegate void LoginAuthentication();
        public static event LoginAuthentication LoginSuccess;
        public static event LoginAuthentication LoginFailure;

        static Dictionary<string, string> userData;
        static LoginExample()
        {
            userData = new Dictionary<string, string>();
            userData.Add("Abhishek", "Palli");
            userData.Add("Vinay", "Dyaga");
            userData.Add("Yash", "Aravind");
            userData.Add("Tushar", "Rajput");
            userData.Add("Shaik", "Irfan");
        }

        public static void Failure()
        {
            Console.WriteLine("Your Credentials are wrong...Try one more time");
        }
        public static void Success()
        {
            Console.WriteLine("Your Credentials are Correct...Welcome to Dashboard...");
        }

        public static void Validate(string user, string pwd)
        {
            string result;
            userData.TryGetValue(user, out result);
            if (result.Equals(pwd))
            {
                LoginSuccess = new LoginAuthentication(Success);
                LoginSuccess.Invoke();
            }
            else
            {
                LoginFailure = new LoginAuthentication(Failure);
                LoginFailure.Invoke();
            }
        }

        static void Main()
        {
            string user, pwd;
            Console.WriteLine("Enter UserName and Password  ");
            user = Console.ReadLine();
            pwd = Console.ReadLine();
            Validate(user, pwd);
        }
    }
}
