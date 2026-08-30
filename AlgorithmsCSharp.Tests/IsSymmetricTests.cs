using IsSymmetricAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class IsSymmetricTests
{
    [Theory]
    [InlineData(56543325, false)]
    [InlineData(12321, true)]
    [InlineData(7, true)]
    [InlineData(123, false)]
    public void IsSymmetric_ReturnsExpectedResult(int number, bool expected)
    {
        Assert.Equal(expected, Program.IsSymmetric(number));
    }
}
