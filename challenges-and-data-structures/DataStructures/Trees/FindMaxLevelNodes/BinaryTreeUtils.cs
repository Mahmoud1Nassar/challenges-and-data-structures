using System;
using System.Collections.Generic;

namespace challenges_and_data_structures.DataStructures.Trees
{
    public class BinaryTreeUtils
    {
        // This method finds the level with the maximum number of nodes in a binary tree.
        public static int FindMaxLevelNodes(BinaryTree.Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty.");
                return -1; // Edge case: Empty tree
            }

            Queue<BinaryTree.Node> queue = new Queue<BinaryTree.Node>();
            queue.Enqueue(root);

            int maxLevel = 0;        // Level with maximum nodes
            int maxNodes = 0;        // Maximum number of nodes at a level
            int currentLevel = 0;    // Track the current level

            // BFS traversal (level-order traversal)
            while (queue.Count > 0)
            {
                int levelSize = queue.Count; // Number of nodes at the current level

                // If the current level has more nodes than the previously recorded maximum,
                // update the maxLevel and maxNodes
                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = currentLevel;
                }

                // Traverse all nodes in the current level
                for (int i = 0; i < levelSize; i++)
                {
                    BinaryTree.Node node = queue.Dequeue();
                    if (node.Left != null) queue.Enqueue(node.Left);
                    if (node.Right != null) queue.Enqueue(node.Right);
                }

                currentLevel++;
            }

            return maxLevel;
        }
    }
}
