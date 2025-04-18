using DataStructures.Stack;

namespace Tests.DataStructures.StackTests;

public class ArrayStackTests
{
    [Fact]
    public void ArrayStack_Push_Test()
    {
        // Arrange
        var stack = new ArrayStack<int>();

        // Act
        stack.Push(10); // 10
        stack.Push(20); // 10 | 20 
        stack.Push(30); // 10 | 20 | 30

        // Assert
        Assert.Equal(3, stack.Count);
    }

    [Fact]
    public void ArrayStack_Pop_Test()
    {
        // Arrange
        var stack = new ArrayStack<int>();
        stack.Push(10); // 10
        stack.Push(20); // 10 | 20 
        stack.Push(30); // 10 | 20 | 30

        // Act
        var result = stack.Pop();

        // Assert
        Assert.Equal(2, stack.Count);
        Assert.Equal(30, result);
    }

    [Fact]
    public void ArrayStack_Peek_Test()
    {
        // Arrange
        var stack = new ArrayStack<int>();
        stack.Push(10); // 10
        stack.Push(20); // 10 | 20 
        stack.Push(30); // 10 | 20 | 30

        // Act
        var result = stack.Peek();

        // Assert
        Assert.Equal(3, stack.Count);
        Assert.Equal(30, result);
    }

    [Fact]
    public void ArrayStack_Constructor_IEnumerable_Test()
    {
        // Arrange & Act
        var stack = new ArrayStack<int>(new List<int>() { 10, 20, 30 });

        // Assert
        Assert.Equal(3, stack.Count);
        Assert.Equal(30, stack.Peek());
    }
}
