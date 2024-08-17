namespace challenges_and_data_structures.DataStructures.Trees
{
    public class TreeMirror
    {
        public static void Mirror(BinaryTree.Node node)
        {
            if (node == null)
                return;

            // Recursively mirror the left and right subtrees
            Mirror(node.Left);
            Mirror(node.Right);

            // Swap the left and right children
            BinaryTree.Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }
    }
}
