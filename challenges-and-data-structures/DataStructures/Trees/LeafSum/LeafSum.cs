using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Trees.LeafSum
{
    public static class LeafSum
    {
        public static int SumOfLeafNodes(BinaryTree tree)
        {
            if (tree == null || tree.Root == null)
            {
                throw new InvalidOperationException("Tree is empty");
            }

            return SumOfLeafNodesRecursive(tree.Root);
        }

        private static int SumOfLeafNodesRecursive(BinaryTree.Node node)
        {
            if (node == null)
                return 0;

            // If the node is a leaf node, return its value
            if (node.Left == null && node.Right == null)
                return node.Data;

            // Otherwise, sum the values of the leaf nodes in the left and right subtrees
            return SumOfLeafNodesRecursive(node.Left) + SumOfLeafNodesRecursive(node.Right);
        }
    }
}
