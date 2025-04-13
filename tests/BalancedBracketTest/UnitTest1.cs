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
        var result = BalancedParenthesesWithStack.BalancedBracketChecker.CheckBalanced(input);
        Assert.Equal(expected, result);
    }
}
