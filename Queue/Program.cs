using System;

namespace QueueAlgorithm
{
    internal class Node<T>
    {
        public T Value;
        public Node<T>? Next;

        public Node(T value)
        {
            Value = value;
        }
    }

    public class CustomQueue<T>
    {
        private Node<T>? _head;
        private Node<T>? _tail;

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public void Enqueue(T item)
        {
            var node = new Node<T>(item);

            if (_tail == null)
            {
                _head = _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }

            Count++;
        }

        public T Dequeue()
        {
            if (_head == null) throw new InvalidOperationException("Queue is empty.");

            T value = _head.Value;
            _head = _head.Next;
            if (_head == null) _tail = null;

            Count--;
            return value;
        }

        public T Peek()
        {
            if (_head == null) throw new InvalidOperationException("Queue is empty.");
            return _head.Value;
        }
    }

    public class Program
    {
        public static void Main()
        {
            var queue = new CustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine($"Peek: {queue.Peek()}");

            while (!queue.IsEmpty)
            {
                Console.WriteLine($"Dequeue: {queue.Dequeue()}");
            }
        }
    }
}
