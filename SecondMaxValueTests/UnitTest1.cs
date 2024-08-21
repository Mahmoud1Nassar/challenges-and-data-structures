using challenges_and_data_structures.DataStructures.Trees;
using System;
using Xunit;

public class SecondMaxValueTests
{
    [Fact]
    public void FindSecondMax_FindsCorrectValue()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root = new BinaryTree.Node(10);
        tree.Root.Left = new BinaryTree.Node(5);
        tree.Root.Right = new BinaryTree.Node(20);
        tree.Root.Left.Left = new BinaryTree.Node(3);
        tree.Root.Left.Right = new BinaryTree.Node(7);
        tree.Root.Right.Left = new BinaryTree.Node(15);
        tree.Root.Right.Right = new BinaryTree.Node(25);

        // Act
        int secondMax = SecondMaxValue.FindSecondMax(tree);

        // Assert
        Assert.Equal(20, secondMax);
    }

    [Fact]
    public void FindSecondMax_ThrowsException_OnTreeWithOneUniqueValue()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root = new BinaryTree.Node(10);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => SecondMaxValue.FindSecondMax(tree));
    }

    [Fact]
    public void FindSecondMax_ThrowsException_OnTreeWithAllIdenticalValues()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root = new BinaryTree.Node(10);
        tree.Root.Left = new BinaryTree.Node(10);
        tree.Root.Right = new BinaryTree.Node(10);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => SecondMaxValue.FindSecondMax(tree));
    }

    [Fact]
    public void FindSecondMax_FindsCorrectValue_WithNegativeValues()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root = new BinaryTree.Node(-10);
        tree.Root.Left = new BinaryTree.Node(-20);
        tree.Root.Right = new BinaryTree.Node(-5);
        tree.Root.Left.Left = new BinaryTree.Node(-30);
        tree.Root.Left.Right = new BinaryTree.Node(-15);

        // Act
        int secondMax = SecondMaxValue.FindSecondMax(tree);

        // Assert
        Assert.Equal(-10, secondMax);
    }

    [Fact]
    public void FindSecondMax_ThrowsException_OnEmptyTree()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => SecondMaxValue.FindSecondMax(tree));
    }
}
