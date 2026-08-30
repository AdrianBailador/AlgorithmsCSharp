using DynamicProgrammingAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class DynamicProgrammingTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(10, 55)]
    [InlineData(30, 832040)]
    public void Fibonacci_Memoized_ReturnsExpectedResult(int n, long expected)
    {
        Assert.Equal(expected, Fibonacci.Memoized(n));
    }

    [Fact]
    public void Fibonacci_Memoized_Throws_OnNegativeInput()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.Memoized(-1));
    }

    [Fact]
    public void Knapsack_PicksBestCombinationWithinCapacity()
    {
        int[] weights = { 2, 3, 4, 5 };
        int[] values = { 3, 4, 5, 6 };

        Assert.Equal(7, Knapsack.MaxValue(weights, values, capacity: 5));
    }

    [Fact]
    public void Knapsack_ReturnsZero_WhenCapacityIsZero()
    {
        int[] weights = { 2, 3 };
        int[] values = { 3, 4 };

        Assert.Equal(0, Knapsack.MaxValue(weights, values, capacity: 0));
    }

    [Fact]
    public void Knapsack_TakesAllItems_WhenCapacityIsSufficient()
    {
        int[] weights = { 1, 2, 3 };
        int[] values = { 10, 15, 40 };

        Assert.Equal(65, Knapsack.MaxValue(weights, values, capacity: 6));
    }

    [Fact]
    public void Knapsack_Throws_WhenArrayLengthsDiffer()
    {
        int[] weights = { 1, 2 };
        int[] values = { 10 };

        Assert.Throws<ArgumentException>(() => Knapsack.MaxValue(weights, values, capacity: 5));
    }
}
