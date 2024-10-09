using System;
using Xunit;
using challenges_and_data_structures.DataStructures.Trees;

namespace challenges_and_data_structures.DataStructures.Tests
{
    public class MinimumDepthTests
    {
        [Fact]
        public void Test_FindMinimumDepth_BalancedTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTree.Node(1);
            tree.Root.Left = new BinaryTree.Node(2);
            tree.Root.Right = new BinaryTree.Node(3);
            tree.Root.Left.Left = new BinaryTree.Node(4);
            tree.Root.Left.Right = new BinaryTree.Node(5);

            // Act
            int minDepth = FindMinimumDepths.FindMinimumDepth(tree.Root);

            // Assert
            Assert.Equal(2, minDepth);  // Expected minimum depth is 2 (root -> 3 or root -> 2)
        }

        [Fact]
        public void Test_FindMinimumDepth_RightSidedTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTree.Node(1);
            tree.Root.Right = new BinaryTree.Node(2);
            tree.Root.Right.Right = new BinaryTree.Node(3);
            tree.Root.Right.Right.Right = new BinaryTree.Node(4);

            // Act
            int minDepth = FindMinimumDepths.FindMinimumDepth(tree.Root);

            // Assert
            Assert.Equal(4, minDepth);  // Expected minimum depth is 4 (root -> 2 -> 3 -> 4)
        }

        [Fact]
        public void Test_FindMinimumDepth_TreeWithBothSides()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTree.Node(1);
            tree.Root.Left = new BinaryTree.Node(2);
            tree.Root.Right = new BinaryTree.Node(3);
            tree.Root.Left.Right = new BinaryTree.Node(5);
            tree.Root.Right.Right = new BinaryTree.Node(6);

            // Act
            int minDepth = FindMinimumDepths.FindMinimumDepth(tree.Root);

            // Assert
            Assert.Equal(3, minDepth);  // Minimum depth is 3 (root -> 1 -> 3 -> 6)
        }

        [Fact]
        public void Test_FindMinimumDepth_EmptyTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act
            int minDepth = FindMinimumDepths.FindMinimumDepth(tree.Root);

            // Assert
            Assert.Equal(0, minDepth);  // Expected minimum depth is 0 (empty tree)
        }
    }
}
