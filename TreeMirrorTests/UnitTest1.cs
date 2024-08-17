using challenges_and_data_structures.DataStructures.Trees;
using System.Collections.Generic;
using Xunit;

public class TreeMirrorTests
{
    [Fact]
    public void TestMirrorTreeAndInOrderTraversal()
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(4);
        Btree.Root.Left = new Node(8);
        Btree.Root.Right = new Node(7);
        Btree.Root.Left.Left = new Node(12);
        Btree.Root.Left.Right = new Node(9);

        // Test original inorder traversal
        List<int> originalInorder = Btree.InorderTraversal();
        Assert.Equal(new List<int> { 12, 8, 9, 4, 7 }, originalInorder);

        // Mirror the tree
        Btree.MirrorTree();

        // Test mirrored inorder traversal
        List<int> mirroredInorder = Btree.InorderTraversal();
        Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
    }

    [Fact]
    public void TestMirrorSingleNodeTree()
    {
        BinaryTree Btree = new BinaryTree();
        Btree.Root = new Node(1);

        // Test original inorder traversal
        List<int> originalInorder = Btree.InorderTraversal();
        Assert.Equal(new List<int> { 1 }, originalInorder);

        // Mirror the tree
        Btree.MirrorTree();

        // Test mirrored inorder traversal
        List<int> mirroredInorder = Btree.InorderTraversal();
        Assert.Equal(new List<int> { 1 }, mirroredInorder);
    }

    [Fact]
    public void TestMirrorEmptyTree()
    {
        BinaryTree Btree = new BinaryTree();

        // Test original inorder traversal
        List<int> originalInorder = Btree.InorderTraversal();
        Assert.Empty(originalInorder);

        // Mirror the tree
        Btree.MirrorTree();

        // Test mirrored inorder traversal
        List<int> mirroredInorder = Btree.InorderTraversal();
        Assert.Empty(mirroredInorder);
    }
}
