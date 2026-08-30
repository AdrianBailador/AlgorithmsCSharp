using LinkedListAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class SinglyLinkedListTests
{
    [Fact]
    public void AddLast_AppendsValuesInOrder()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        Assert.Equal(new[] { 1, 2, 3 }, list.ToEnumerable());
        Assert.Equal(3, list.Count);
    }

    [Fact]
    public void Remove_DeletesFirstMatchingValue()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        bool removed = list.Remove(2);

        Assert.True(removed);
        Assert.Equal(new[] { 1, 3 }, list.ToEnumerable());
        Assert.Equal(2, list.Count);
    }

    [Fact]
    public void Remove_ReturnsFalse_WhenValueMissing()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);

        Assert.False(list.Remove(99));
    }

    [Fact]
    public void Contains_FindsExistingValue()
    {
        var list = new SinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);

        Assert.True(list.Contains(2));
        Assert.False(list.Contains(3));
    }
}
