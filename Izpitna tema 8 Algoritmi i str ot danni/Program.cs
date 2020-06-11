using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Izpitna_tema_8_Algoritmi_i_str_ot_danni
{
    class Program
    {
        static readonly Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
        static Tree<int> GetTreeNodeByValue(int value)
        {
            if (!nodeByValue.ContainsKey(value))            //Fixed null check
            {
                return null;
            }
            nodeByValue[value] = new Tree<int>(value);
            return nodeByValue[value];
        }
        static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);

            if (parentNode == null)                             //Check if nodes are null, if so add them to the tree
            {
                nodeByValue.Add(parent, new Tree<int>(child));
            }
            else if (childNode == null)
            {
                nodeByValue.Add(child, null);
            }
            else
            {
                parentNode.AddChild(childNode);
                childNode.SetParent(parentNode);
            }

        }
        static Tree<int> GetRoot()
        {
            Tree<int> root = nodeByValue.Values.Where(x => x.Parent == null).FirstOrDefault();
            return root;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < (n-1); i++)                 //Fixed syntax errors
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                AddEdge(input[0], input[1]);
            }
            Console.WriteLine("The root of the tree is {0}", GetRoot().Value);
        }
    }
}
