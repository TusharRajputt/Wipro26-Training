using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{ class LeapYear1
    #region Input Year
    {
        int year;
       
        public void GetYear()
        {
            Console.WriteLine("Enter Year: ");
            year=int.Parse(Console.ReadLine());

        }
        #endregion Input Year
    #region Leap Year check
        public void CheckLeap()
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("It's a Leap Year");
            }
            else 
                Console.WriteLine("It's not a leap Year");
        }
         # endregion Leap Year check

    }
    #region Main Method
    internal class Prog9
       
    {
        static void Main()
        {
            LeapYear1 obj=new LeapYear1();
            obj.GetYear();
            obj.CheckLeap();
           Console.ReadLine();
        }
        #endregion Main Method

    }
}
