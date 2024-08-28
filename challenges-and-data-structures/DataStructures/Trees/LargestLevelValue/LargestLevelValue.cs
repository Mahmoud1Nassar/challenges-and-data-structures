using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.DataStructures.Trees.LargestLevelValue
{
    public static class LargestLevelValueCalculator
    {
        public static List<int> LargestValueEachLevel(BinaryTree tree)
        {
            if (tree == null || tree.Root == null)
            {
                throw new InvalidOperationException("Tree is empty");
            }

            List<int> largestValues = new List<int>();
            Queue<BinaryTree.Node> queue = new Queue<BinaryTree.Node>();
            queue.Enqueue(tree.Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxLevelValue = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    BinaryTree.Node currentNode = queue.Dequeue();
                    if (currentNode.Data > maxLevelValue)
                    {
                        maxLevelValue = currentNode.Data;
                    }

                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }

                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }

                largestValues.Add(maxLevelValue);
            }

            return largestValues;
        }
    }
}
