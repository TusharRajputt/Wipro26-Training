using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{
    internal class CheckPalindrome
    { static bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j) // run loop till middle character or until both meets
            {
                while (i < j && !char.IsLetterOrDigit(s[i])) // runs from start until finds a character or digit and ignoring spaces
                {
                    i++;
                }
                while (i < j && !char.IsLetterOrDigit(s[j]))// runs from end until finds a character or digit and ignores spaces
                {
                    j--;
                }


                if (s[i]!=s[j]) // checks if [i] is equal to [j] if not then set boolean to false and return it
                {
                  return  false;
                }

                i++;
                j--;
            }
            return true;// if both are equal then boolean returns true.
        } 
    
     static void Main()
        {
            Console.WriteLine("Enter a line: ");
            string s = Console.ReadLine().ToLower();// takes input and converts to lower case to handle upper and lower case 

            bool result = IsPalindrome(s);
            Console.WriteLine(result);
        }

    }

}
