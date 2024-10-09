using System;
using Xunit;
using challenges_and_data_structures.DataStructures.Trees;

namespace challenges_and_data_structures.DataStructures.Tests
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void Test_FindMaxLevelNodes_BalancedTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTree.Node(1);
            tree.Root.Left = new BinaryTree.Node(2);
            tree.Root.Right = new BinaryTree.Node(3);
            tree.Root.Left.Left = new BinaryTree.Node(4);
            tree.Root.Left.Right = new BinaryTree.Node(5);
            tree.Root.Right.Right = new BinaryTree.Node(6);
            tree.Root.Left.Left.Left = new BinaryTree.Node(7);

            // Act
            int maxLevel = BinaryTreeUtils.FindMaxLevelNodes(tree.Root);

            // Assert
            Assert.Equal(2, maxLevel);  // Expected level with max nodes is level 2 (nodes 4, 5, 6)
        }

        [Fact]
        public void Test_FindMaxLevelNodes_RightSidedTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTree.Node(1);
            tree.Root.Right = new BinaryTree.Node(2);
            tree.Root.Right.Right = new BinaryTree.Node(3);
            tree.Root.Right.Right.Right = new BinaryTree.Node(4);

            // Act
            int maxLevel = BinaryTreeUtils.FindMaxLevelNodes(tree.Root);

            // Assert
            Assert.Equal(0, maxLevel);  // Expected level with max nodes is level 0 (root level, since all nodes are in a single branch)
        }

        [Fact]
        public void Test_FindMaxLevelNodes_MultipleLevelsWithSameNodes()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTree.Node(1);
            tree.Root.Left = new BinaryTree.Node(2);
            tree.Root.Right = new BinaryTree.Node(3);
            tree.Root.Left.Left = new BinaryTree.Node(4);
            tree.Root.Left.Right = new BinaryTree.Node(5);
            tree.Root.Right.Left = new BinaryTree.Node(6);
            tree.Root.Right.Right = new BinaryTree.Node(7);

            // Act
            int maxLevel = BinaryTreeUtils.FindMaxLevelNodes(tree.Root);

            // Assert
            Assert.Equal(2, maxLevel);  // Level 2 has 4 nodes (4, 5, 6, 7)
        }

        [Fact]
        public void Test_FindMaxLevelNodes_EmptyTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();

            // Act
            int maxLevel = BinaryTreeUtils.FindMaxLevelNodes(tree.Root);

            // Assert
            Assert.Equal(-1, maxLevel);  // Empty tree, should return -1
        }
    }
}
