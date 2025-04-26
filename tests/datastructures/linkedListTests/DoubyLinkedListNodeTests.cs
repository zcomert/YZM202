
using DataStructures.LinkedList.Doubly;

namespace linkedListTests;

public class DbNodeTests
{
    [Fact]
    public void AddNewDbNode_Test()
    {
        var node = new DbNode<char>('a');
        var node1 = new DbNode<char>('b');
        var node2 = new DbNode<char>('c');

        node.Next = node1;
        node1.Prev = node;

        node1.Next = node2;
        node2.Prev = node1;

        Assert.Equal(node1, node.Next);
        Assert.Null(node.Prev);
        Assert.True(node1.Next.Equals(node2));
        Assert.True(node.Next.Value.Equals(node2.Prev.Value));
    }

    [Fact]
    public void ConnectTwoNode()
    {
        var node = new DbNode<float>(1.1f);
        var node2 = new DbNode<float>(2.2f);

        node.Next = node2;
        node2.Prev = node;

        Assert.Equal(node2, node.Next);
        Assert.Equal(node, node2.Prev);
        Assert.Equal(2.2f, node.Next.Value);
        Assert.Equal(1.1f, node2.Prev.Value);
    }

    [Fact]
    public void Constructor_WithValue_SetsValue()
    {
        var node = new DbNode<int>(5);

        Assert.True(node.Value.Equals(5));
    }

    [Fact]
    public void Constructor_WithoutValue_ValueIsNull()
    {
        var node = new DbNode<int>();
        node.Value = 5;

        Assert.True(node.Value.Equals(5));

    }

    [Fact]
    public void NextProperty_CanBeSetAndGet()
    {
        var node = new DbNode<int>(5);
        var new_node = new DbNode<int>(10);

        node.Next = new_node;

        Assert.Equal(10, node.Next.Value); // new_node.Value
    }

    [Fact]
    public void PrevProperty_CanBeSetAndGet()
    {
        var node = new DbNode<int>(5);
        var new_node = new DbNode<int>(10);

        node.Prev = new_node;
        new_node.Next = node;

        Assert.NotNull(node.Prev);
        Assert.NotNull(node.Prev.Next);
        if (new_node.Prev is not null && new_node.Prev.Next is not null)
            Assert.Equal(10, new_node.Prev.Next.Value);
    }

    [Fact]
    public void ToString_ReturnsValueAsString()
    {
        var node = new DbNode<int>(10);

        Assert.Equal("10", node.ToString()); // new_node.Value
    }
}