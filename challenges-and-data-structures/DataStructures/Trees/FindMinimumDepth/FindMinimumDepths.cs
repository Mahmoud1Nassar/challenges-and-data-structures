using System;
using System.Collections.Generic;

namespace challenges_and_data_structures.DataStructures.Trees
{
    public class FindMinimumDepths
    {
        // This method finds the minimum depth of a binary tree.
        public static int FindMinimumDepth(BinaryTree.Node root)
        {
            if (root == null) return 0; // Edge case: Empty tree

            Queue<(BinaryTree.Node node, int depth)> queue = new Queue<(BinaryTree.Node, int)>();
            queue.Enqueue((root, 1)); // Start BFS traversal from the root with depth 1

            while (queue.Count > 0)
            {
                var (node, depth) = queue.Dequeue();

                // If we encounter a leaf node (node with no children), return the depth
                if (node.Left == null && node.Right == null)
                    return depth;

                // Add the left child if it exists
                if (node.Left != null)
                    queue.Enqueue((node.Left, depth + 1));

                // Add the right child if it exists
                if (node.Right != null)
                    queue.Enqueue((node.Right, depth + 1));
            }

            return 0; // Default return, shouldn't reach here as the tree will always have at least one node
        }
    }
}
