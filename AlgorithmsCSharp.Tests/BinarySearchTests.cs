using BinarySearchAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class BinarySearchTests
{
    private static readonly int[] SortedArray = { 2, 3, 4, 10, 40 };

    [Theory]
    [InlineData(10, 3)]
    [InlineData(2, 0)]
    [InlineData(40, 4)]
    public void BinarySearch_FindsPresentValue(int target, int expectedIndex)
    {
        int result = Program.BinarySearch(SortedArray, 0, SortedArray.Length - 1, target);
        Assert.Equal(expectedIndex, result);
    }

    [Fact]
    public void BinarySearch_ReturnsMinusOne_WhenValueMissing()
    {
        int result = Program.BinarySearch(SortedArray, 0, SortedArray.Length - 1, 5);
        Assert.Equal(-1, result);
    }
}
