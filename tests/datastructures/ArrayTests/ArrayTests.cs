using DataStructures.Array;

namespace ArrayTests;

public class ArrayTests
{
    [Fact]
    public void Check_Count_And_Capacity()
    {
        // Arrange
        var numbers = new Array<int>(4);
        numbers.Add(19);
        numbers.Add(25);
        numbers.Add(71);
        numbers.Add(77);
        numbers.Add(52);
        numbers.Add(31);

        // Act
        var count = numbers.Count;
        var capacity = numbers.Capacity;

        // Assert
        Assert.Equal(6, count);
        Assert.Equal(8, capacity);
    }

    [Fact]
    public void GetValue_ValidIndex_ReturnsCorrectValue()
    {
        // Arrange
        var numbers = new Array<int>(4);
        numbers.Add(19);
        numbers.Add(25);
        numbers.Add(71);

        // Act
        var value = numbers.GetValue(1);

        // Assert
        Assert.Equal(25, value);
    }

    [Fact]
    public void RemoveAt_Test()
    {
        // Arrange
        var numbers = new Array<int>(new int[] { 0, 1, 2, 3, 4 });

        // Act
        var item = numbers.RemoveAt(1);

        // Assertion
        Assert.Equal(1, item);
        Assert.True(numbers.Count == 4);
        Assert.Equal(2, numbers.RemoveAt(1));
    }

    [Fact]
    public void Remove_Test()
    {
        var numbers = new Array<int>(new int[] { 0, 1, 2, 3, 4 });

        // Act
        var item = numbers.Remove();

        // Assertion
        Assert.Equal(4, item);
        Assert.True(numbers.Count == 4);
        Assert.Equal(3, numbers.Remove());
    }

    [Fact]
    public void Sort_Test()
    {
        var numbers = new Array<int>(new int[] { 1, 3, 2, 5, 4 });

        numbers.Sort();

        Assert.Equal(2, numbers.GetItem(1));
    }
}