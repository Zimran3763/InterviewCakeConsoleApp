﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    //this is a class to store each node and it's depth
    public class NodeDepthPair
    {
        public int Depth { get; }//need to find why we don't need set?
        public BinaryTreeNode Node { get; }
        public NodeDepthPair(BinaryTreeNode node, int depth)
        {
            Node = node;
            Depth = depth;
        }

        public static bool IsBalanced(BinaryTreeNode treeRoot)
        {

            // a tree with no nodes is superbalanced, since there are no leaves!
            if (treeRoot == null)
            {
                return true;
            }

            // We short-circuit as soon as we find more than 2
            // and return false if it's difference is >1
            var depths = new List<int>(3);  

            // Nodes will store pairs of a node and the node's depth
            //stack store last value on zero index and move previous value to index 1 because we always pop zero index value
            //So last value should be on the zero index so we can pop it
            var nodes = new Stack<NodeDepthPair>();
            nodes.Push(new NodeDepthPair(treeRoot, 0));

            while (nodes.Count > 0)
            {
                // Pop a node and its depth from the top of our stack
                // And we are storing poped node into nodeDepthPair variable
                var nodeDepthPair = nodes.Pop();
                //popped node value 
                var node = nodeDepthPair.Node;
                //popped node depth
                var depth = nodeDepthPair.Depth;

                if (node.Left == null && node.Right == null)
                {
                    // Case: we found a leaf


                    // We only care if it's a new depth
                    //means depths list does not have exact depth
                    if (!depths.Contains(depth))
                    {
                        depths.Add(depth);

                        // Two ways we might now have an unbalanced tree:
                        //   1) more than 2 different leaf depths
                        //   2) 2 leaf depths that are more than 1 apart
                        if (depths.Count > 2
                            || (depths.Count == 2 && Math.Abs(depths[0] - depths[1]) > 1))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    // Case: this isn't a leaf - keep stepping down

                    if (node.Left != null)
                    {
                        nodes.Push(new NodeDepthPair(node.Left, depth + 1));
                    }

                    if (node.Right != null)
                    {
                        nodes.Push(new NodeDepthPair(node.Right, depth + 1));
                    }
                }
            }

            return true;
        }
    }


}
