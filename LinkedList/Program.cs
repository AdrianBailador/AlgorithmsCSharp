using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListAlgorithm
{
    public class Node<T>
    {
        public T Value;
        public Node<T>? Next;

        public Node(T value)
        {
            Value = value;
        }
    }

    public class SinglyLinkedList<T>
    {
        private Node<T>? _head;

        public int Count { get; private set; }

        public void AddLast(T value)
        {
            var node = new Node<T>(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                Node<T> current = _head;
                while (current.Next != null) current = current.Next;
                current.Next = node;
            }

            Count++;
        }

        public bool Remove(T value)
        {
            Node<T>? current = _head;
            Node<T>? previous = null;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value))
                {
                    if (previous == null) _head = current.Next;
                    else previous.Next = current.Next;

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            Node<T>? current = _head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, value)) return true;
                current = current.Next;
            }

            return false;
        }

        public IEnumerable<T> ToEnumerable()
        {
            Node<T>? current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (T value in ToEnumerable())
            {
                sb.Append(value);
                sb.Append(" -> ");
            }
            sb.Append("null");
            return sb.ToString();
        }
    }

    public class Program
    {
        public static void Main()
        {
            var list = new SinglyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Console.WriteLine(list);

            list.Remove(2);
            Console.WriteLine(list);

            Console.WriteLine($"Contains 3: {list.Contains(3)}");
            Console.WriteLine($"Contains 2: {list.Contains(2)}");
        }
    }
}
