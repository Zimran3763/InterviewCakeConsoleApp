using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class FindSecondLargestNode
    {
        public static int FindLargest(BinaryTreeNode rootNode)
        {
            var current = rootNode;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Value;
        }

        public static int FindSecondLargest(BinaryTreeNode rootNode)
        {
            if (rootNode == null
                || (rootNode.Left == null && rootNode.Right == null))
            {
                throw new ArgumentException("Tree must have at least 2 nodes",
                    nameof(rootNode));
            }

            var current = rootNode;

            while (true)//it's true becuase as soon as we find our node we return it and it will break this loop
            {
                // Case: current is largest and has a left subtree
                // 2nd largest is the largest in that subtree
                if (current.Left != null && current.Right == null)
                {
                    return FindLargest(current.Left);
                }

                // Case: current is parent of largest, and largest has no children,
                // so current is 2nd largest
                if (current.Right != null
                    && current.Right.Left == null
                    && current.Right.Right == null)
                {
                    return current.Value;
                }

                current = current.Right;//keep replacing current as we go deeper down so we can find above one condition out of two
            }
        }
    }
}
