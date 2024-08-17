using challenges_and_data_structures.DataStructures.Trees;
using System.Collections.Generic;
using Xunit;

namespace TreeTests
{
    public class TreeMirrorTests
    {
        [Fact]
        public void TestMirrorTreeAndInOrderTraversal()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new BinaryTree.Node(4);
            Btree.Root.Left = new BinaryTree.Node(8);
            Btree.Root.Right = new BinaryTree.Node(7);
            Btree.Root.Left.Left = new BinaryTree.Node(12);
            Btree.Root.Left.Right = new BinaryTree.Node(9);

            // Act - Inorder traversal before mirroring
            List<int> originalInorder = Btree.InorderTraversal();
            TreeMirror.Mirror(Btree.Root);  // Perform the mirror operation
            List<int> mirroredInorder = Btree.InorderTraversal();

            // Assert - Verify original inorder traversal
            Assert.Equal(new List<int> { 12, 8, 9, 4, 7 }, originalInorder);

            // Assert - Verify mirrored inorder traversal
            Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
        }

        [Fact]
        public void TestMirrorSingleNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new BinaryTree.Node(1);

            // Act - Inorder traversal before and after mirroring
            List<int> originalInorder = Btree.InorderTraversal();
            TreeMirror.Mirror(Btree.Root);
            List<int> mirroredInorder = Btree.InorderTraversal();

            // Assert - Inorder traversal should remain the same
            Assert.Equal(new List<int> { 1 }, originalInorder);
            Assert.Equal(new List<int> { 1 }, mirroredInorder);
        }

        [Fact]
        public void TestMirrorEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act - Inorder traversal before and after mirroring
            List<int> originalInorder = Btree.InorderTraversal();
            TreeMirror.Mirror(Btree.Root);
            List<int> mirroredInorder = Btree.InorderTraversal();

            // Assert - Inorder traversal should be empty
            Assert.Empty(originalInorder);
            Assert.Empty(mirroredInorder);
        }
    }
}