using SortingAlgorithms;

namespace AlgorithmsCSharp.Tests;

public class SortingAlgorithmsTests
{
    private static readonly int[] Unsorted = { 64, 34, 25, 12, 22, 11, 90 };
    private static readonly int[] Expected = { 11, 12, 22, 25, 34, 64, 90 };

    [Fact]
    public void BubbleSort_SortsArray()
    {
        int[] arr = (int[])Unsorted.Clone();
        Program.BubbleSort(arr);
        Assert.Equal(Expected, arr);
    }

    [Fact]
    public void SelectionSort_SortsArray()
    {
        int[] arr = (int[])Unsorted.Clone();
        Program.SelectionSort(arr);
        Assert.Equal(Expected, arr);
    }

    [Fact]
    public void InsertionSort_SortsArray()
    {
        int[] arr = (int[])Unsorted.Clone();
        Program.InsertionSort(arr);
        Assert.Equal(Expected, arr);
    }

    [Fact]
    public void MergeSort_SortsArray()
    {
        int[] result = Program.MergeSort((int[])Unsorted.Clone());
        Assert.Equal(Expected, result);
    }

    [Fact]
    public void QuickSort_SortsArray()
    {
        int[] arr = (int[])Unsorted.Clone();
        Program.QuickSort(arr, 0, arr.Length - 1);
        Assert.Equal(Expected, arr);
    }

    [Fact]
    public void MergeSort_HandlesEmptyArray()
    {
        int[] result = Program.MergeSort(Array.Empty<int>());
        Assert.Empty(result);
    }
}
