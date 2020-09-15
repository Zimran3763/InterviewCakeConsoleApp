using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    public class GraphNode
    {
        public string Label { get; }//don't need set because we are setting it in constructor//it's more safe
        public ISet<GraphNode> Neighbors { get; }//.NET 4 includes two sets, HashSet<T> and SortedSet<T>, that both implement the interface ISet<T>. 
        public string Color 
        { 
            get; 
            set; //setting it outside constructor
        }
        public bool HasColor
        { 
            get 
            { 
                return Color != null; 
            } 
        }

        public GraphNode(string label)
        {
            Label = label;
            Neighbors = new HashSet<GraphNode>();
        }

        public void AddNeighbor(GraphNode neighbor)
        {
            Neighbors.Add(neighbor);
        }
        public static string[] GetColors()
        {
            return new string[] { "Red", "Green", "Blue", "Orange", "Yellow", "White" };
        }
        //public static void ValidateGraphColoring(GraphNode[] graph)
        //{
        //    var nonColoredNode = graph.FirstOrDefault(n => !n.HasColor);
        //    if (nonColoredNode != null)
        //    {
        //        Fail($"Found non-colored node {nonColoredNode.Label}");
        //    }

        //    int maxDegree = 0;
        //    var usedColors = new HashSet<string>();

        //    foreach (var node in graph)
        //    {
        //        maxDegree = Math.Max(maxDegree, node.Neighbors.Count);
        //        usedColors.Add(node.Color);
        //    }

        //    var allowedColorCount = maxDegree + 1;

        //    if (usedColors.Count > allowedColorCount)
        //    {
        //        Fail("Too many colors:"
        //             + $" {allowedColorCount} allowed, but {usedColors.Count} actually used");
        //    }

        //    foreach (var node in graph)
        //    {
        //        var neighbor = node.Neighbors.FirstOrDefault(n => n.Color == node.Color);
        //        if (neighbor != null)
        //        {
        //            Fail($"Neighbor nodes {node.Label} and {neighbor.Label}"
        //                 + $" have the same color {node.Color}");
        //        }
        //    }
        //}
        //public static void Fail(string message)
        //{
        //   // Assert.True(false, message);
        //}
        public static void ColorGraph(GraphNode[] graph, string[] colors)
        {
            foreach (var node in graph)
            {
                if (node.Neighbors.Contains(node))
                {
                    throw new ArgumentException(
                        "Legal coloring impossible for node with loop: ${node.Label}",
                        nameof(graph));
                }

                // Get the node's neighbors' colors, as a set so we
                // can check if a color is illegal in constant time
                //Used Linq query 
                var illegalColors = new HashSet<string>(
                    from neighbor in node.Neighbors
                    where neighbor.Color != null
                    select neighbor.Color);

                // Assign the first legal color
                node.Color = colors.First(c => !illegalColors.Contains(c));
            }
        }
    }

}
