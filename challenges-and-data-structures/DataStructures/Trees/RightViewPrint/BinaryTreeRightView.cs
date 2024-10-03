using System;
using System.Collections.Generic;

namespace challenges_and_data_structures.DataStructures.Trees
{
    public class BinaryTreeRightView
    {
        // Method to print the right view of the binary tree
        public static void PrintRightView(BinaryTree.Node root)
        {
            if (root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

            Queue<BinaryTree.Node> queue = new Queue<BinaryTree.Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count; // Get the number of nodes at the current level

                for (int i = 0; i < levelSize; i++)
                {
                    BinaryTree.Node currentNode = queue.Dequeue();

                    // If it's the last node in this level, print it
                    if (i == levelSize - 1)
                    {
                        Console.WriteLine(currentNode.Data);
                    }

                    // Add left child to the queue
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    // Add right child to the queue
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
            }
        }
    }
}
