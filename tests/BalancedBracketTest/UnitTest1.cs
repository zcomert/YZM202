namespace BalancedBracketTest;
using Xunit;

public class UnitTest1
{
    [Theory]
    [InlineData("[{]", false)]
    [InlineData("(())", true)]
    [InlineData("{}]}", false)]
    [InlineData("{({})}", true)]
    public void Test1(string input, bool expected)
    {
        //Act
        var result = BalancedParenthesesWithStack.BalancedBracketChecker.CheckBalanced(input);

        //Assert
        Assert.Equal(expected, result);
    }
}
