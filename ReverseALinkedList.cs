using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class ReverseALinkedList
    {
        public static LinkedListNode Reverse(LinkedListNode headOfList)
        {
            LinkedListNode currentNode = headOfList;
            LinkedListNode previousNode = null;
            LinkedListNode nextNode = null;

            // Until we have 'fallen off' the end of the list
            while (currentNode != null)
            {
                // Copy a pointer to the next element
                // before we overwrite currentNode.Next
                nextNode = currentNode.Next;

                // Reverse the 'Next' pointer
                currentNode.Next = previousNode;

                // Step forward in the list
                previousNode = currentNode;
                currentNode = nextNode;
            }

            return previousNode;
        }
    }
}
