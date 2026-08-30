using ReverseNumberBAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class ReverseNumberTests
{
    [Theory]
    [InlineData(757757574, 475757757)]
    [InlineData(123, 321)]
    [InlineData(100, 1)]
    [InlineData(0, 0)]
    public void ReverseNumber_ReturnsExpectedResult(int number, int expected)
    {
        Assert.Equal(expected, Program.ReverseNumber(number));
    }
}
