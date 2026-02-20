using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamles
{
    internal class Voting
    {
        public void Check(int age)
        {
            if (age < 18)
            {
                throw new VotingException("You Are Not Elligible For Voting...");
            }
            Console.WriteLine("You Can Vote...");
        }
        static void Main()
        {
            int age;
            Console.WriteLine("Enter Your Age   ");
            age = Convert.ToInt32(Console.ReadLine());
            Voting voting = new Voting();
            try
            {
                voting.Check(age);
            }
            catch(VotingException v)
            {
                Console.WriteLine(v.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
