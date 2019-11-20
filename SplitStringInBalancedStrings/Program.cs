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
            int i = 0;
            for (var j = 0; j < s.Length; j++)
            {  //Queue the items; as soon as you see a transition...
                if (queue.Count() == 0)
                {
                    queue.Enqueue(s[j]);
                }
                if (queue.Count>0 && s[j] == queue.Peek())
                {
                   queue.Enqueue(s[j]);
                   continue;
                }  else if (queue.Count() > 0 && s[j] != queue.Peek())
                {  // i.e. if c is different from what is in the queue
                   //start taking items out of the queue and build a string
                   
                   sb.Append(queue.Dequeue());
                   sb.Append(s[j]);
                   continue;
                }
            }
            return counter;
        }
    }
}
