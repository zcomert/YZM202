using bits;

namespace bitsTests;

public class BitTests
{
    [Fact]
    public void convert_8bits_to_int8_or_byte()
    {
        // Arrange
        var bit = "00000001";
        var conversion = new Conversion();

        // Act
        var result = conversion.ToNumber(bit);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void convert_8bits_to_int8_or_byte_with_conversion()
    {
        // Arrange
        var bit = "00000001";
        var conversion = new Conversion();

        // Act
        var result = conversion.ToNumber(bit);
        var convertResult = Convert.ToByte(bit, 2);

        // Assert
        Assert.True(result == convertResult);
    }

    [Fact]
    public void convert_8bits_to_sbyte()
    {
        // Arrange
        var bit = "10000001";
        var conversion = new Conversion();

        // Act
        var result = conversion.ToUNumber(bit);

        // Assert
        Assert.Equal(-127, result);
    }

    [Fact]
    public void convert_8bits_to_sbyte_with_conversion()
    {
        // Arrange
        var bit = "10000001";
        var conversion = new Conversion();

        // Act
        var result = conversion.ToUNumber(bit);
        var convertResult = Convert.ToSByte(bit, 2);

        // Assert
        Assert.True(result == convertResult);
    }
}
