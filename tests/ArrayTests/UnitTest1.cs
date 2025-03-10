using DataStructures.Array;

namespace ArrayTests;

public class UnitTest1
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

    


}