using DataStructures.LinkedList.Singly;

namespace Tests.LinkedListTests;

public class SinglyLinkedListTests
{
    // GLobal
    SinglyLinkedList<int> linkedList;

    public SinglyLinkedListTests()
    {
        this.linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3 });
    }

    [Fact]
    public void NewLinkedListIsEmpty()
    {
        // Assert
        Assert.False(linkedList.IsEmpty);
    }

    [Fact]
    public void LinkedListWithCollectionIsPopulated()
    {
        // Arrange
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

        // Act
        linkedList = new SinglyLinkedList<int>(arr);

        // Assert
        Assert.False(linkedList.IsEmpty);
        Assert.Equal(6, linkedList.Head.Value);
    }

    [Fact]
    public void AddFirstAddsElementToLinkedList()
    {
        linkedList.AddFirst(6);

        Assert.Equal(6, linkedList.Head.Value);
        Assert.Equal(3, linkedList.Head.Next.Value);
        Assert.Equal(4, linkedList.Count);
    }

    [Fact]
    public void AddLastAddsElementToEndOfLinkedList()
    {
        linkedList.AddLast(6);

        Assert.Equal(6, linkedList.Head.Next.Next.Next.Value);
        Assert.Equal(3, linkedList.Head.Value);
        Assert.Equal(4, linkedList.Count);
    }


    [Fact]
    public void AddAfterThrowsExceptionIfNodeNotFound()
    {
        Assert.Throws<Exception>(() => linkedList.AddAfter(new SinglyLinkedListNode<int>(5), 1));
    }
    [Fact]
    public void AddAfterNullCheck()
    {
        //Arrange
        var linkedList = new SinglyLinkedList<int>();
        var head_node = linkedList.Head;
        //Act
        linkedList.AddAfter(head_node, 9);
        //Assert
        Assert.Equal(9, linkedList.Head.Value);
    }
    [Fact]
    public void AddAfterAddsElementsToLinkedList()
    {
        //Arrange
        var node2 = linkedList.Head.Next;
        //Act
        linkedList.AddAfter(node2, 8);
        //Assert
        Assert.Equal(8, linkedList.Head.Next.Next.Value);
        Assert.Equal(4, linkedList.Count);
    }

    [Fact]
    public void AddBeforeAddsElementBeforeGivenNode()
    {
        // Arrange
        var item = linkedList.Head;

        // Act
        linkedList.AddBefore(linkedList.Head.Next, 8);
        // Assert

        Assert.Equal(3, item.Value);
        Assert.Equal(8, item.Next.Value);
        Assert.Equal(2, item.Next.Next.Value);
        Assert.Equal(1, item.Next.Next.Next.Value);
    }
    [Fact]
    public void AddBeforeNullCheck()
    {
        //Arrange
        var linkedList = new SinglyLinkedList<int>();
        var head_node = linkedList.Head;
        //Act
        linkedList.AddBefore(head_node, 6);
        //Assert
        Assert.Equal(6, linkedList.Head.Value);
    }

    [Fact]
    public void AddBeforeThrowsExceptionIfNodeNotFound()
    {
        Assert.Throws<Exception>(() => linkedList.AddBefore(new SinglyLinkedListNode<int>(5), 1));
    }

    [Fact]
    public void RemoveNullCheck()
    {
        //Arrange
        var linkedList = new SinglyLinkedList<int>();
        //Act
        var head_node = linkedList.Head;
        //Assert
        Assert.Throws<Exception>(() => linkedList.Remove(head_node));
    }

    [Fact]
    public void RemoveFirstRemovesFirstElement()
    {
        // Act
        var item = linkedList.RemoveFirst();

        // Assert
        Assert.Equal(3, item);
    }

    [Fact]
    public void RemoveFirstThrowsExceptionIfListIsEmpty()
    {
        linkedList = new SinglyLinkedList<int>();
        Assert.Throws<Exception>(() => linkedList.RemoveLast());
    }

    [Fact]
    public void RemoveLastRemovesLastElement()
    {
        // Act
        var item = linkedList.RemoveLast();

        // Assert
        Assert.Equal(1, item);
    }

    [Fact]
    public void RemoveLastThrowsExceptionIfListIsEmpty()
    {
        linkedList = new SinglyLinkedList<int>();
        Assert.Throws<Exception>(() => linkedList.RemoveLast());
    }

    [Fact]
    public void RemoveRemovesGivenNode()
    {
        // Act
        var item = linkedList.Remove(new SinglyLinkedListNode<int>(2));

        // Assert
        Assert.Equal(2, item);
    }

    [Fact]
    public void RemoveThrowsExceptionIfNodeNotFound()
    {
        //linkedList = new SinglyLinkedList<int>();

        Assert.Throws<Exception>(() => linkedList.Remove(new SinglyLinkedListNode<int>(4)));
    }
}
