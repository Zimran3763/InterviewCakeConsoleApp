using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class SinglyListContainsCycle
    {
        public static bool ContainsCycle(LinkedListNode firstNode)
        {
            // Start both runners at the beginning
            var slowRunner = firstNode;
            var fastRunner = firstNode;

            // Until we hit the end of the list
            while (fastRunner != null && fastRunner.Next != null)
            {
                slowRunner = slowRunner.Next;
                fastRunner = fastRunner.Next.Next;

                // Case: fastRunner is about to "lap" slowRunner
                if (fastRunner == slowRunner)
                {
                    return true;
                }
            }

            // Case: fastRunner hit the end of the list
            return false;
        }
        public static LinkedListNode[] ValuesToLinkedListNodes(int[] values)
        {
            var nodes = new LinkedListNode[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                nodes[i] = new LinkedListNode(values[i]);
                if (i > 0)
                {
                    nodes[i - 1].Next = nodes[i];
                }
            }
            return nodes;
        }
    }
}
