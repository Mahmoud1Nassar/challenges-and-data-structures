using System;

namespace challenges_and_data_structures.DataStructures.Trees
{
    public class SecondMaxValue
    {
        public static int FindSecondMax(BinaryTree tree)
        {
            if (tree == null || tree.Root == null)
            {
                throw new InvalidOperationException("Tree is empty");
            }

            int max = int.MinValue;
            int secondMax = int.MinValue;

            FindSecondMaxRecursive(tree.Root, ref max, ref secondMax);

            if (secondMax == int.MinValue)
            {
                throw new InvalidOperationException("Tree does not have enough unique values");
            }

            return secondMax;
        }

        private static void FindSecondMaxRecursive(BinaryTree.Node node, ref int max, ref int secondMax)
        {
            if (node == null)
                return;

            if (node.Data > max)
            {
                secondMax = max;
                max = node.Data;
            }
            else if (node.Data > secondMax && node.Data < max)
            {
                secondMax = node.Data;
            }

            FindSecondMaxRecursive(node.Left, ref max, ref secondMax);
            FindSecondMaxRecursive(node.Right, ref max, ref secondMax);
        }
    }
}
