using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{
    class Pair 
    {
        public char ch;
        public int count;

        public Pair(char c,int cnt)
        {
            ch = c;
            count=cnt;
        }

    }
    internal class ConsecutiveIdenticals
    {
      static string CheckPairs(string s, int k)
        {
            Stack<Pair> stack = new Stack<Pair>();// creating a new stack


            foreach(char c in s)
            {
                if (c == ' ') continue;// ignores spaces
                if (stack.Count > 0 && stack.Peek().ch == c)// if stack is not empty and top element is same the count++
                {
                    stack.Peek().count++;
                    if (stack.Peek().count == k)// if count reaches till k then pop the element from stack
                    {
                        stack.Pop();
                    }

                }
                else 
                {
                    stack.Push(new Pair(c, 1)); // if stack is empty or previous character is different push new character with count 1
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach(var items in stack)// var detects type and items is variable through which we can access the elements
            {
                sb.Insert(0, new string(items.ch, items.count));// insert 0 at begining helps to print the character in correct order i.e last element comes first so we insert it at 0 and then the next element also comes at 0 making the previous one to move to 1
            }
            return sb.ToString();
        }



        static void Main()
        {
            Console.WriteLine("Enter a line: ");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the value of k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CheckPairs(s,k));

        }
    }
}
