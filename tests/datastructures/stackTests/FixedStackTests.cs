using DataStructures.Stack;
using Xunit;

namespace Tests.DataStructures.StackTests;

public class FixedStackTestsTest
{
    [Fact]
    public void Push_ShouldAddItemToStack()
    {
        // Arrange
        var stack = new FixedStack<int>(2);

        // Act
        stack.Push(1);
        stack.Push(2);

        // Assert
        Assert.Equal(2, stack.Count);
    }

    [Fact]
    public void Push_ShouldThrowException_WhenStackIsFull()
    {
        // Arrange
        var stack = new FixedStack<int>(2);
        stack.Push(1);
        stack.Push(2);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => stack.Push(3));
    }

    [Fact]
    public void Pop_ShouldRemoveItemFromStack()
    {
        // Arrange
        var stack = new FixedStack<int>(2);
        stack.Push(1);
        stack.Push(2);

        // Act
        var poppedItem = stack.Pop();

        // Assert
        Assert.Equal(2, poppedItem);
        Assert.Equal(1, stack.Count);
    }

    [Fact]
    public void Pop_ShouldThrowException_WhenStackIsEmpty()
    {
        // Arrange
        var stack = new FixedStack<int>(2);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }
}