using System;
using System.IO;
using System.Text;
using Xunit;

namespace challenges_and_data_structures.DataStructures.Trees.Tests
{
    public class BinaryTreeRightViewTests
    {
        [Fact]
        public void Test_PrintRightView_BalancedTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTree.Node(1);
            tree.Root.Left = new BinaryTree.Node(2);
            tree.Root.Right = new BinaryTree.Node(3);
            tree.Root.Left.Left = new BinaryTree.Node(4);
            tree.Root.Left.Right = new BinaryTree.Node(5);
            tree.Root.Right.Right = new BinaryTree.Node(6);
            tree.Root.Right.Right.Right = new BinaryTree.Node(7);

            // Redirect console output
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            BinaryTreeRightView.PrintRightView(tree.Root);

            // Assert
            var output = stringWriter.ToString().Trim();
            var expectedOutput = "1\n3\n6\n7";  // The expected right view of the binary tree
            Assert.Equal(expectedOutput, output);
        }

        [Fact]
        public void Test_PrintRightView_RightSideOnlyTree()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new BinaryTree.Node(1);
            tree.Root.Right = new BinaryTree.Node(2);
            tree.Root.Right.Right = new BinaryTree.Node(3);
            tree.Root.Right.Right.Right = new BinaryTree.Node(4);

            // Redirect console output
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            BinaryTreeRightView.PrintRightView(tree.Root);

            // Assert
            var output = stringWriter.ToString().Trim();
            var expectedOutput = "1\n2\n3\n4";  // The expected right view of the right-sided binary tree
            Assert.Equal(expectedOutput, output);
        }
    }
}
