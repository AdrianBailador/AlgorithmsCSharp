using IsPrimeAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class IsPrimeTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(17, true)]
    [InlineData(97, true)]
    [InlineData(1, false)]
    [InlineData(4, false)]
    [InlineData(100, false)]
    public void IsPrime_ReturnsExpectedResult(int number, bool expected)
    {
        Assert.Equal(expected, Program.IsPrime(number));
    }
}
