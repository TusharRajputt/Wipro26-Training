using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{
    internal class FirstNonRepeating
    {
         static char NonRep(string s)
        {
            
            int[] freq = new int[50];
            // counting frequency of each character
            foreach (char c in s)
            {
                if (!char.IsLetter(c)) continue;// this skips to next loop if spaces comes

                freq[c - 'a']++;
            }
            // finding the 1st non-repeating character
            foreach (char c in s)
            {
                if (!char.IsLetter(c)) continue; // skips to next loop if spaces comes
                if (freq[c - 'a'] == 1)
                {
                    
                    return c ;
                }
            }
            //if found nothing returning'$
            return '$';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line: ");
            // Converting the input to lower case to handle both upper and lower case characters
            string s=Console.ReadLine().ToLower();

            //storing the result in result
            char result = NonRep(s);
            //printing the result
            Console.WriteLine("First Non-Repeating Character: "+result);

        }
    }
}
