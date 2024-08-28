using challenges_and_data_structures.DataStructures.Trees;
using challenges_and_data_structures.DataStructures.Trees.LargestLevelValue;
using System;
using System.Collections.Generic;
using Xunit;

public class LargestLevelValueCalculatorTests
{
    [Fact]
    public void LargestValueEachLevel_FindsCorrectValues()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();
        tree.Root = new BinaryTree.Node(5);
        tree.Root.Left = new BinaryTree.Node(13);
        tree.Root.Right = new BinaryTree.Node(7);
        tree.Root.Left.Left = new BinaryTree.Node(3);
        tree.Root.Left.Right = new BinaryTree.Node(7);
        tree.Root.Right.Left = new BinaryTree.Node(12);
        tree.Root.Right.Right = new BinaryTree.Node(20);
        tree.Root.Left.Left.Left = new BinaryTree.Node(1);
        tree.Root.Left.Left.Right = new BinaryTree.Node(4);
        tree.Root.Right.Left.Right = new BinaryTree.Node(11);

        // Act
        List<int> largestValues = LargestLevelValueCalculator.LargestValueEachLevel(tree);

        // Assert
        Assert.Equal(new List<int> { 5, 13, 20, 11 }, largestValues);
    }

    [Fact]
    public void LargestValueEachLevel_ThrowsException_OnEmptyTree()
    {
        // Arrange
        BinaryTree tree = new BinaryTree();

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => LargestLevelValueCalculator.LargestValueEachLevel(tree));
    }
}
