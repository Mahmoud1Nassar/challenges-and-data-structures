using challenges_and_data_structures.DataStructures.Trees;
using challenges_and_data_structures.DataStructures.Trees.LeafSum;
using System;
using Xunit;

public class LeafSumCalculatorTests
{
    [Fact]
    public void SumOfLeafNodes_FindsCorrectValue()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root = new BinaryTree.Node(9);
        tree.Root.Left = new BinaryTree.Node(8);
        tree.Root.Right = new BinaryTree.Node(12);
        tree.Root.Left.Left = new BinaryTree.Node(3);
        tree.Root.Left.Right = new BinaryTree.Node(7);
        tree.Root.Right.Left = new BinaryTree.Node(17);
        tree.Root.Right.Right = new BinaryTree.Node(23);
        tree.Root.Left.Left.Right = new BinaryTree.Node(4);

        // Act
        int leafSum = LeafSum.SumOfLeafNodes(tree);

        // Assert
        Assert.Equal(51, leafSum);
    }

    [Fact]
    public void SumOfLeafNodes_FindsCorrectValue_WithNegativeLeafValues()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root = new BinaryTree.Node(9);
        tree.Root.Left = new BinaryTree.Node(8);
        tree.Root.Right = new BinaryTree.Node(12);
        tree.Root.Left.Left = new BinaryTree.Node(3);
        tree.Root.Left.Right = new BinaryTree.Node(7);
        tree.Root.Right.Left = new BinaryTree.Node(17);
        tree.Root.Right.Right = new BinaryTree.Node(-23); // Negative leaf value
        tree.Root.Left.Left.Right = new BinaryTree.Node(4);

        // Act
        int leafSum = LeafSum.SumOfLeafNodes(tree);

        // Assert
        Assert.Equal(5, leafSum); // 4 + 7 + 17 + (-23) = 5
    }

    [Fact]
    public void SumOfLeafNodes_ThrowsException_OnEmptyTree()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => LeafSum.SumOfLeafNodes(tree));
    }
}
