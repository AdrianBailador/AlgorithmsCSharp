using StackAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class CustomStackTests
{
    [Fact]
    public void Push_ThenPop_ReturnsValuesInLifoOrder()
    {
        var stack = new CustomStack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Assert.Equal(3, stack.Pop());
        Assert.Equal(2, stack.Pop());
        Assert.Equal(1, stack.Pop());
        Assert.True(stack.IsEmpty);
    }

    [Fact]
    public void Peek_ReturnsTopWithoutRemoving()
    {
        var stack = new CustomStack<int>();
        stack.Push(1);
        stack.Push(2);

        Assert.Equal(2, stack.Peek());
        Assert.Equal(2, stack.Count);
    }

    [Fact]
    public void Pop_Throws_WhenEmpty()
    {
        var stack = new CustomStack<int>();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void Push_GrowsBeyondInitialCapacity()
    {
        var stack = new CustomStack<int>();
        for (int i = 0; i < 20; i++) stack.Push(i);

        Assert.Equal(20, stack.Count);
        Assert.Equal(19, stack.Pop());
    }
}
