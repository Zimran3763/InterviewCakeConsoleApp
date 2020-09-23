using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class kthNodeInSinglyList
    {
        public static LinkedListNode KthToLastNode(int k, LinkedListNode head)
        {
            if (k < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(k),
                    $"Impossible to find less than first to last node: {k}");
            }

            var leftNode = head;
            var rightNode = head;

            // Move rightNode to the kth node
            for (int i = 0; i < k - 1; i++)
            {
                // But along the way, if a rightNode doesn't have a next,
                // then k is greater than the length of the list and there
                // can't be a kth-to-last node! we'll raise an error
                if (rightNode.Next == null)
                {
                    throw new ArgumentOutOfRangeException(nameof(k),
                        $"k is larger than the length of the linked list: {k}");
                }

                rightNode = rightNode.Next;
            }

            // Starting with leftNode on the head,
            // move leftNode and rightNode down the list,
            // maintaining a distance of k between them,
            // until rightNode hits the end of the list
            while (rightNode.Next != null)
            {
                leftNode = leftNode.Next;
                rightNode = rightNode.Next;
            }

            // Since leftNode is k nodes behind rightNode,
            // leftNode is now the kth to last node!
            return leftNode;
        }
    }
}
