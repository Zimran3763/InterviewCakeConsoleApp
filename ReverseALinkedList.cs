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
            LinkedListNode tempNextNode = null;

            // Until we have 'fallen off' the end of the list
            while (currentNode != null)
            {
                // Copy currenNodeNext value to a temp variable. So if we use change the value of current.next we would not loose original value
                tempNextNode = currentNode.Next;

                // Reverse the 'Next' pointer
                //   1--->2 would be null<---1<---2
                // so currentnode next which was pointing 2 now it's pointing to previous node which is null
                currentNode.Next = previousNode;

                // Step forward in the list
                // now make current node previous node
                previousNode = currentNode;

                //and use tempNext variable to make next node 2 as a current node
                currentNode = tempNextNode;
            }

            return previousNode;
        }
    }
}
