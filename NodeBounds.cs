using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class NodeBounds
    {
        public BinaryTreeNode Node { get; }

        public int LowerBound { get; }

        public int UpperBound { get; }

        public NodeBounds(BinaryTreeNode node, int lowerBound, int upperBound)
        {
            Node = node;
            LowerBound = lowerBound;
            UpperBound = upperBound;
        }


        public static bool IsBinarySearchTree(BinaryTreeNode root)
        {
            // Start at the root, with an arbitrarily low lower bound
            // and an arbitrarily high upper bound
            var nodeAndBoundsStack = new Stack<NodeBounds>();
            nodeAndBoundsStack.Push(new NodeBounds(root, int.MinValue, int.MaxValue));

            // Depth-first traversal
            while (nodeAndBoundsStack.Count > 0)
            {
                var nb = nodeAndBoundsStack.Pop();
                var node = nb.Node;
                var lowerBound = nb.LowerBound;
                var upperBound = nb.UpperBound;

                // If this node is invalid, we return false right away
                if (node.Value <= lowerBound || node.Value >= upperBound)
                {
                    return false;
                }

                if (node.Left != null)
                {
                    // This node must be less than the current node
                    nodeAndBoundsStack.Push(new NodeBounds(node.Left, lowerBound, node.Value));
                }

                if (node.Right != null)
                {
                    // This node must be greater than the current node
                    nodeAndBoundsStack.Push(new NodeBounds(node.Right, node.Value, upperBound));
                }
            }

            // If none of the nodes were invalid, return true
            // (at this point we have checked all nodes)
            return true;
        }
    }
}
