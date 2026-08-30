using FactorialCalculatorAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class FactorialCalculatorTests
{
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    [InlineData(10, 3628800)]
    public void FactorialIterative_ReturnsExpectedResult(int number, long expected)
    {
        Assert.Equal(expected, Program.FactorialIterative(number));
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    [InlineData(10, 3628800)]
    public void FactorialRecursive_ReturnsExpectedResult(int number, long expected)
    {
        Assert.Equal(expected, Program.FactorialRecursive(number));
    }
}
