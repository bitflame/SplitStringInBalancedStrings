using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitStringInBalancedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "RLRRLLRLRL";
            //Debug.Assert(BalancedStringSplit(testString) == 4);
            Console.WriteLine(BalancedStringSplit(testString));
            Console.ReadLine();
        }
        private static int BalancedStringSplit (string s)
        {
            //List<String[]> matchingStrings = new List<string[]>();
            Queue<char> queue = new Queue<char>();
            StringBuilder sb;
            int counter = 0;
            foreach (var c in s)
            {  //Queue the items; as soon as you see a transition...
                
                if (c == 'R')
                {
                    
                    queue.Enqueue(c);
                }  else
                {   
                   sb = new StringBuilder();
                   while (queue.Count>0)//start taking items out of the queue and build a string
                   {
                     sb.Append(queue.Dequeue());
                     sb.Append(c);
                   }
                   Console.WriteLine(sb);
                   if (sb.Length > 0) { counter++; }
                }
                
            }

            return counter;
        }
    }
}
