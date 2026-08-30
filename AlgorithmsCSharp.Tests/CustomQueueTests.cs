using QueueAlgorithm;

namespace AlgorithmsCSharp.Tests;

public class CustomQueueTests
{
    [Fact]
    public void Enqueue_ThenDequeue_ReturnsValuesInFifoOrder()
    {
        var queue = new CustomQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.Equal(1, queue.Dequeue());
        Assert.Equal(2, queue.Dequeue());
        Assert.Equal(3, queue.Dequeue());
        Assert.True(queue.IsEmpty);
    }

    [Fact]
    public void Peek_ReturnsFrontWithoutRemoving()
    {
        var queue = new CustomQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.Equal(1, queue.Peek());
        Assert.Equal(2, queue.Count);
    }

    [Fact]
    public void Dequeue_Throws_WhenEmpty()
    {
        var queue = new CustomQueue<int>();
        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }

    [Fact]
    public void Dequeue_ThenEnqueueAgain_KeepsWorking()
    {
        var queue = new CustomQueue<int>();
        queue.Enqueue(1);
        queue.Dequeue();
        queue.Enqueue(2);

        Assert.Equal(2, queue.Dequeue());
        Assert.True(queue.IsEmpty);
    }
}
