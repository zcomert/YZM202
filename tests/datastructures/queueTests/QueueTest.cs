namespace Tests.DataStructures.QueueTests;
using DataStructures.Queue;
public class QueueTest
{
    [Fact]
    public void Enqueue_ShouldAddItemToQueue()
    {
        // Arrange
        var queue = new DataStructures.Q
        // Act
        queue.Enqueue(1);

        // Assert
        Assert.Equal(1, queue.Count);
        Assert.Equal(1, queue.Peek());
    }

    // [Fact]
    // public void Dequeue_ShouldRemoveAndReturnItemFromQueue()
    // {
    //     // Arrange
    //     var queue = new Queue<int>();
    //     queue.Enqueue(1);
    //     queue.Enqueue(2);

    //     // Act
    //     var dequeuedItem = queue.Dequeue();

    //     // Assert
    //     Assert.Equal(1, dequeuedItem);
    //     Assert.Equal(1, queue.Count);
    //     Assert.Equal(2, queue.Peek());
    // }

    // [Fact]
    // public void Peek_ShouldReturnFirstItemWithoutRemovingIt()
    // {
    //     // Arrange
    //     var queue = new Queue<int>();
    //     queue.Enqueue(1);
    //     queue.Enqueue(2);

    //     // Act
    //     var peekedItem = queue.Peek();

    //     // Assert
    //     Assert.Equal(1, peekedItem);
    //     Assert.Equal(2, queue.Count);
    // }

    // [Fact]
    // public void Count_ShouldReturnNumberOfItemsInQueue()
    // {
    //     // Arrange
    //     var queue = new Queue<int>();
    //     queue.Enqueue(1);
    //     queue.Enqueue(2);

    //     // Act
    //     var count = queue.Count;

    //     // Assert
    //     Assert.Equal(2, count);
    // }

    // [Fact]
    // public void Dequeue_OnEmptyQueue_ShouldThrowInvalidOperationException()
    // {
    //     // Arrange
    //     var queue = new Queue<int>();

    //     // Act & Assert
    //     Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    // }

    // [Fact]
    // public void Peek_OnEmptyQueue_ShouldThrowInvalidOperationException()
    // {
    //     // Arrange
    //     var queue = new Queue<int>();

    //     // Act & Assert
    //     Assert.Throws<InvalidOperationException>(() => queue.Peek());
    // }
}