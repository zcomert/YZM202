using DataStructures.DisjointSet;
using Xunit;

namespace Tests.DisjointSetNodeTests;

public class DisjointSetNodeTests
{
    // Tests that the constructor sets the Value and default Rank, and Parent is null.
    [Fact]
    public void Constructor_Should_Set_Value_And_Default_Rank()
    {
        var node = new DisjointSetNode<string>("NodeA");

        Assert.Equal("NodeA", node.Value);
        Assert.Equal(0, node.Rank);
        Assert.Null(node.Parent); // Parent atanmamıştır
    }

    // Tests that the constructor with rank parameter sets Value and Rank, and Parent is null.
    [Fact]
    public void Constructor_With_Rank_Should_Set_Value_And_Rank()
    {
        var node = new DisjointSetNode<int>(42, 2);

        Assert.Equal(42, node.Value);
        Assert.Equal(2, node.Rank);
        Assert.Null(node.Parent); // Parent atanmamıştır
    }

    // Tests that the Parent property can be assigned and retrieved.
    [Fact]
    public void Parent_Can_Be_Assigned()
    {
        var parent = new DisjointSetNode<int>(1);
        var child = new DisjointSetNode<int>(2);
        child.Parent = parent;

        Assert.Equal(parent, child.Parent);
    }

    // Tests that ToString returns the string representation of Value.
    [Fact]
    public void ToString_Should_Return_Value_String()
    {
        var node = new DisjointSetNode<string>("MyValue");

        var result = node.ToString();

        Assert.Equal("MyValue", result);
    }

    // Tests that the default constructor sets Value and Parent to null, and Rank to 0.
    [Fact]
    public void Default_Constructor_Should_Set_Null_Fields()
    {
        var node = new DisjointSetNode<object>();

        Assert.Null(node.Value);
        Assert.Equal(0, node.Rank);
        Assert.Null(node.Parent);
    }
}
