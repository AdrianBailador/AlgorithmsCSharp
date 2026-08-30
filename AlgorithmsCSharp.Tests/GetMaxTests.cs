using GetMaxAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class GetMaxTests
{
    [Theory]
    [InlineData(376543245, 7)]
    [InlineData(-376543245, 7)]
    [InlineData(0, 0)]
    [InlineData(111, 1)]
    public void FindMaxDigit_ReturnsExpectedResult(int number, int expected)
    {
        Assert.Equal(expected, Program.FindMaxDigit(number));
    }
}
