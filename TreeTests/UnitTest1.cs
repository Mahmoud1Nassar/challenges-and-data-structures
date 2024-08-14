using challenges_and_data_structures.DataStructures.Trees;
using System.Collections.Generic;
using Xunit;

public class TreeTests
{
    [Fact]
    public void TestPreOrderTraversal()
    {
        TreeImplementation bst = new TreeImplementation();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(7);

        List<int> result = new List<int>();
        bst.PreOrder(bst.Root, result);

        Assert.Equal(new List<int> { 10, 5, 7, 15 }, result);
    }

    [Fact]
    public void TestInOrderTraversal()
    {
        TreeImplementation bst = new TreeImplementation();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(7);

        List<int> result = new List<int>();
        bst.InOrder(bst.Root, result);

        Assert.Equal(new List<int> { 5, 7, 10, 15 }, result);
    }

    [Fact]
    public void TestPostOrderTraversal()
    {
        TreeImplementation bst = new TreeImplementation();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(7);

        List<int> result = new List<int>();
        bst.PostOrder(bst.Root, result);

        Assert.Equal(new List<int> { 7, 5, 15, 10 }, result);
    }

    [Fact]
    public void TestAddNode()
    {
        TreeImplementation bst = new TreeImplementation();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);

        Assert.True(bst.Contains(10));
        Assert.True(bst.Contains(5));
        Assert.True(bst.Contains(15));
    }

    [Fact]
    public void TestContainsNode()
    {
        TreeImplementation bst = new TreeImplementation();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);

        Assert.True(bst.Contains(10));
        Assert.False(bst.Contains(7));
    }

    [Fact]
    public void TestRemoveNode()
    {
        TreeImplementation bst = new TreeImplementation();
        bst.Add(10);
        bst.Add(5);
        bst.Add(15);
        bst.Add(7);

        bst.Remove(5);

        Assert.False(bst.Contains(5));
        Assert.True(bst.Contains(7));
    }
}
