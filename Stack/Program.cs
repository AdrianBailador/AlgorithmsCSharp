using System;

namespace StackAlgorithm
{
    public class CustomStack<T>
    {
        private T[] _items = new T[4];

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public void Push(T item)
        {
            if (Count == _items.Length) Array.Resize(ref _items, _items.Length * 2);
            _items[Count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("Stack is empty.");
            return _items[--Count];
        }

        public T Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("Stack is empty.");
            return _items[Count - 1];
        }
    }

    public class Program
    {
        public static void Main()
        {
            var stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Peek: {stack.Peek()}");

            while (!stack.IsEmpty)
            {
                Console.WriteLine($"Pop: {stack.Pop()}");
            }
        }
    }
}
